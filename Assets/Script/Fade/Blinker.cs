using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Blinker : MonoBehaviour
{
    public float nextTime;
    public float interval = 1.0f;   // 点滅周期
    public bool on;
    // Use this for initialization
    void Start()
    {
        nextTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            nextTime = Time.time;
            on = false;
        }
        if (Time.time > nextTime)
        {
            var renderComponent = GetComponent<Renderer>();
            renderComponent.enabled = !renderComponent.enabled;
            
            nextTime += interval;
        }
    }
}