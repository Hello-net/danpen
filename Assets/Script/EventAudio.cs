using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EventAudio : MonoBehaviour
{
    RawImage m_rawImage;
    [SerializeField]
    private GameObject Layer;
    public AudioManager AMscript;
    public string audioName;
    public float SEvolume = 0.5f;
    public float BGMvolume = 0.5f;


    public void MyPointerUpUI()
    {
        AudioManager.Instance.PlaySE(audioName, 0f);
        AMscript.ChangeVolume(BGMvolume,SEvolume);
        m_rawImage.enabled = false;
        m_rawImage.texture = null;
    }

    private void Awake()
    {
        m_rawImage = Layer.GetComponent<RawImage>();
    }
}