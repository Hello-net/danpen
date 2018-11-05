using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EventStart : MonoBehaviour
{

    public void MyPointerDownUI()
    {
        Debug.Log("押された");
        SceneManager.LoadScene("Main");
    }

    public void MyDragUI()
    {
        transform.position = Input.mousePosition;
    }
}