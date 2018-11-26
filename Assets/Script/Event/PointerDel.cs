using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointerDel : MonoBehaviour {

    RawImage m_rawImage;
    [SerializeField]
    private GameObject Layer;

    // Use this for initialization
    void Awake()
    {
        m_rawImage = Layer.GetComponent<RawImage>();
    }

    // Update is called once per frame
    public void MyPointerUpUI ()
    {
        m_rawImage.enabled = false;
        m_rawImage.texture = null;
    }
}
