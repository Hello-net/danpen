using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{

    GameObject fadeObj;
    float startTime;
    public int fadeTime;
    Color alpha;
    string fadeStart;
    public int fadeout = 0;
    public string loadscean;


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
                fadeObj.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, alpha.a);
                break;
            case "FadeOut":
                alpha.a = (Time.time - startTime) / fadeTime;
                fadeObj.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, alpha.a);
                break;
        }
        
        if (fadeout == 1)
        {
            fadeStart = "FadeOut";
            startTime = Time.time;
            Invoke("Load", 3f);
            fadeout = 0;
        }
    }
    public void Load()
    {
        //string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(loadscean);
    }
}