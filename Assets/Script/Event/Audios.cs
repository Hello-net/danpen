using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audios : MonoBehaviour {

    RawImage m_rawImage;
    [SerializeField]
    private GameObject Layer;
    public AudioManager AMscript;
    public string audioName;
    public float SEvolume = 0.5f;
    public float BGMvolume = 0.5f;
    public float second;

    // Use this for initialization
    void Start () {
        m_rawImage = Layer.GetComponent<RawImage>();
    }
	
	// Update is called once per frame
	void Update () {
        if(m_rawImage.texture != null)
        {
            Invoke("AudioStart",second);
            m_rawImage.enabled = false;
            m_rawImage.texture = null;
        }
    }
    
    void AudioStart()
    {
        AudioManager.Instance.PlaySE(audioName, 0f);
        AMscript.ChangeVolume(BGMvolume, SEvolume);
    }
}
