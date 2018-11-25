using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutRawImage : MonoBehaviour
{
    RawImage rawImage;
    Color alpha;
    [SerializeField]
    GameObject Layer;
    Delete delete;
    public float FadeTime;

    // Use this for initialization
    void Start()
    {
        delete = GetComponent<Delete>();
    }

    // Update is called once per frame
    public void Update()
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