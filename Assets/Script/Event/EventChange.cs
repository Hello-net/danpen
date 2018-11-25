using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EventChange : MonoBehaviour
{
    public GameObject GM;
    [SerializeField] private ScenarioManager smScript;
    public string filename = "prologue";


    public void MyPointerUpUI()
    {
        GM.SetActive(false);
        GM.SetActive(true);
        Invoke("Load", 1.0f);

    }

    void Load()
    {
        smScript.LoadFileName = filename;
        smScript.Start();
    }
}
