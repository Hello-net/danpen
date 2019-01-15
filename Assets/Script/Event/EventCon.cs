using UnityEngine;
using System.Collections;

public class EventCon : MonoBehaviour
{
    public string SceaneName;
    [SerializeField]
    private Fade fade;
    [SerializeField]
    private FadeOutImage fs; 

    public void MyPointerUpUI()
    {
        fs.enabled = true;
        fade.enabled = true;
        fade.loadscean = SceaneName;
        fade.fadeout = 1;
    }
}