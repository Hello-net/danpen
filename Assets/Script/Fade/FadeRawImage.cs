using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeRawImage : MonoBehaviour
{
    RawImage rawImage;
    Color alpha;
    [SerializeField]
    GameObject Layer;
    Delete delete;
    public float FadeTime;
    public bool In;

    // Use this for initialization
    void Start()
    {
        delete = GetComponent<Delete>();
    }

    // Update is called once per frame
    void Update()
    {
        if (In)
        {
            rawImage = Layer.GetComponent<RawImage>();
            alpha.a = alpha.a >= 1 ? 0 : alpha.a + FadeTime;
            rawImage.color = new Color(255, 255, 255, alpha.a);
            if (alpha.a >= 1)
            {
                delete.Del();
                this.enabled = false;
            }
        }
        else
        {
            rawImage = Layer.GetComponent<RawImage>();
            alpha.a = alpha.a <= 0 ? 1 : alpha.a - FadeTime;
            rawImage.color = new Color(255, 255, 255, alpha.a);
            if (alpha.a < 0)
            {
                delete.Del();
                this.enabled = false;
            }
        }
    }

}