using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Fade : MonoBehaviour
{

    GameObject fadeObj;

    float startTime;

    public int fadeTime;
    Color alpha;
    string fadeStart;

    // Use this for initialization
    void Start()
    {

        fadeObj = GameObject.Find("Fade");
        startTime = Time.time;
        fadeStart = "FadeIn";

    }

    // Update is called once per frame
    void Update()
    {

        switch (fadeStart)
        {
            case "FadeIn":
                alpha.a = 1.0f - (Time.time - startTime) / fadeTime;
                fadeObj.GetComponent().color = new Color(0, 0, 0, alpha.a);
                break;
            case "FadeOut":
                alpha.a = (Time.time - startTime) / fadeTime;
                fadeObj.GetComponent().color = new Color(0, 0, 0, alpha.a);
                break;
        }

        if (Input.GetButtonDown("Jump"))
        {
            fadeStart = "FadeOut";
            startTime = Time.time;
            Invoke("Load", 1.5f);
        }
    }
    public void Load()
    {
        Application.LoadLevel(Application.loadedLevelName);
    }
}