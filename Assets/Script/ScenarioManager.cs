using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;

[RequireComponent(typeof(TextController))]
public class ScenarioManager : SingletonMonoBehaviourFast<ScenarioManager>
{

    public string LoadFileName;
    [SerializeField]
    private GameObject soul;

    private string[] m_scenarios;
    private int m_currentLine = 0;
    private bool m_isCallPreload = false;
    [SerializeField]
    private Blinker blinker;
    private TextController m_textController;
    private CommandController m_commandController;
    private Renderer renderComponent;
    

    void RequestNextLine()
    {
        renderComponent.enabled = false;
        blinker.on = true;
        soul.SetActive(false);
        var currentText = m_scenarios[m_currentLine];

        m_textController.SetNextLine(CommandProcess(currentText));
        m_currentLine++;
        m_isCallPreload = false;
    }

    public void UpdateLines(string fileName)
    {
        var scenarioText = Resources.Load<TextAsset>("Scenario/" + fileName);

        if (scenarioText == null)
        {
            Debug.LogError("シナリオファイルが見つかりませんでした");
            Debug.LogError("ScenarioManagerを無効化します");
            enabled = false;
            return;
        }
        m_scenarios = scenarioText.text.Split(new string[] { "@br" }, System.StringSplitOptions.None);
        m_currentLine = 0;

        Resources.UnloadAsset(scenarioText);
    }

    private string CommandProcess(string line)
    {
        var lineReader = new StringReader(line);
        var lineBuilder = new StringBuilder();
        var text = string.Empty;
        while ((text = lineReader.ReadLine()) != null)
        {
            var commentCharacterCount = text.IndexOf("//");
            if (commentCharacterCount != -1)
            {
                text = text.Substring(0, commentCharacterCount);
            }

            if (!string.IsNullOrEmpty(text))
            {
                if (text[0] == '@' && m_commandController.LoadCommand(text))
                    continue;
                lineBuilder.AppendLine(text);
            }
        }

        return lineBuilder.ToString();
    }

    #region UNITY_CALLBACK

    public void Start()
    {
        m_textController = GetComponent<TextController>();
        m_commandController = GetComponent<CommandController>();
        renderComponent = soul.GetComponent<Renderer>();
        UpdateLines(LoadFileName);
        RequestNextLine();
    }

    void Update()
    {
        if (m_textController.IsCompleteDisplayText)
        {
            soul.SetActive(true);
            if (m_currentLine < m_scenarios.Length)
            {
                if (!m_isCallPreload)
                {
                    m_commandController.PreScenario(m_scenarios[m_currentLine]);
                    m_isCallPreload = true;
                }

                if (Input.GetMouseButtonUp(0))
                {
                    RequestNextLine();
                }
            }
        }
        else
        {
            if (Input.GetMouseButtonUp(0))
            {
                m_textController.ForceCompleteDisplayText();
            }
        }
    }

    #endregion
}