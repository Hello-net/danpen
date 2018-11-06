using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set : MonoBehaviour {

    public GameObject go;
    float time = 0.0f;

	// Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        //go = GameObject.Find("GameMaster");
        time = time + Time.deltaTime;
        if(time > 3.0f)
        { 
            go.SetActive(true);
            end();
        }

	}

    void end()
    {
        GetComponent<Set>().enabled = false;
    }

    void Awake()
    {
        //go = GameObject.Find("GameMaster");
        //go.SetActive(false);
    }
}
