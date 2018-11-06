using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor;

public class EventChange : MonoBehaviour
{
    GameObject SC;
    private Script SCfn;

    void Start()
    {
        SC = GameObject.Find("GameMaster");
        SCfn = SC.GetComponent<ScenarioManager>();
    }

    public void MyPointerDownUI()
    {
        Debug.Log("押された");
        SCfn.LoadFileName = prologue;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
