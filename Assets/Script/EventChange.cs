using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EventChange : MonoBehaviour
{
    public GameObject GM;
    public GameObject GM2;

    void Start()
    {

    }

    public void MyPointerUpUI()
    {
        GM.SetActive(false);
        GM2.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
