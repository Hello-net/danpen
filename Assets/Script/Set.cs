using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set : MonoBehaviour {

    public GameObject go;
    public FadeText fadetext;
    public AudioManager AMscript;
    public float intime = 0;
    public float intime2 = 0;
    float time = 0.0f;
    bool flag = true ;
    


	// Use this for initialization
	void Start () {
        //AudioManager.Instance.PlayBGM(AUDIO.BGM_YOU);
        //AMscript.ChangeVolume(0.02f,1f);
    }

    // Update is called once per frame
    void Update () {
        time = time + Time.deltaTime;
        if (time > intime && flag)
        {
            fadetext.enabled = true;
            flag = false;
        }
        if (time > intime2)
        { 
            go.SetActive(true);
            end();
        }

	}

    void end()
    {
        GetComponent<Set>().enabled = false;
    }
}
