using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EventCon : MonoBehaviour
{

    public void MyPointerUpUI()
    {
        Debug.Log("押された");
        SceneManager.LoadScene("Main");
    }
}