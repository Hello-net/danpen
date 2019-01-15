using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventGo : MonoBehaviour {


    public string SceaneName;
    [SerializeField]
    private Fade fade;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
        public void MyPointerUpUI()
        {
            fade.enabled = true;
            fade.loadscean = SceaneName;
            fade.fadeout = 1;
        }

}
