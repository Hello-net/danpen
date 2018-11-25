using UnityEngine;
using System.Collections;

public class EventStart: MonoBehaviour
{
    public GameObject start;
    public FadeOutImage fade;
    public float fadesec ;
    public Fade FadeScript;


    public void MyPointerDownUI()
    {
        Debug.Log("押された");
        fade.enabled = true;
        Invoke("Load", fadesec);
    }

    public void Load()
    {
        FadeScript.fadeout = 1;
    }
}