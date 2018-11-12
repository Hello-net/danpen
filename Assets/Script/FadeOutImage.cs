using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutImage : MonoBehaviour {

    Color alpha;
    public GameObject fadeObj;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	public void Update () {
        alpha.a = alpha.a <= 0 ? 1 : alpha.a - 0.01f;
        //Debug.Log(alpha.a);
        fadeObj.GetComponent<Image>().color = new Color(255,255,255,alpha.a);
        if(alpha.a < 0)
        {
            this.enabled = false;
        }
    }
  
}
