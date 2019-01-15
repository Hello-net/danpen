using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInText : MonoBehaviour {

    public Text text;
    public float FadeTime;
    public FadeInText Fade;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Color color = text.color;
        color.a = color.a >= 1 ? 0 : color.a + FadeTime;
        if (color.a >= 1)
        {
            Fade.enabled = true;
            this.enabled = false;
        }
        text.color = color;
    }

}
