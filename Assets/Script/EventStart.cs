using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EventStart: MonoBehaviour
{
    public GameObject start;
    public FadeOutImage fade;
    public float fadesec ;


    public void MyPointerDownUI()
    {
        Debug.Log("押された");
        fade.enabled = true;
        Invoke("Load", fadesec);
    }

    public void Load()
    {
        SceneManager.LoadScene("Main");
    }
}