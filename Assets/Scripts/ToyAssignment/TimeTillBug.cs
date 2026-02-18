using UnityEngine;
using UnityEngine.UI;

public class TimeTillBug : MonoBehaviour
{
    //time till the next duck spawns
    public Slider timer;
    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 10)
        {
            t = 0;
        }
        timer.value = t;
    }
}
