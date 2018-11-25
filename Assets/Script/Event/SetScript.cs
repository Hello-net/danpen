using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScript : MonoBehaviour {

    public FadeRawImage script;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void MyPointerUpUI()
    {
        script.enabled = true;
        end();
    }

    void end()
    {
        this.enabled = false;
    }
}