using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fire : MonoBehaviour
{
    public GameObject prop;
    public Transform start;
    float t;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * 10 * Time.deltaTime;
        t += Time.deltaTime;
        if (t > 2)
        {
            t = 0;
            Destroy(prop);
        }
    }
    
}
