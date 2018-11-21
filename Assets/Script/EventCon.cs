using UnityEngine;
using System.Collections;

public class EventCon : MonoBehaviour
{
    public string SceaneName;
    [SerializeField]
    private Fade fade;

    public void MyPointerUpUI()
    {
        fade.loadscean = SceaneName;
        fade.fadeout = 1;
    }
}