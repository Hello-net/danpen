using UnityEngine;
using UnityEngine.UI;

public class FadeText : MonoBehaviour
{
    public Text text;

    void Update()
    {
        Color color = text.color;
        color.a = color.a <= 0 ? 1 : color.a - 0.01f;
        if(color.a < 0)
        {
            this.enabled = false;
        }
        text.color = color;
    }
}