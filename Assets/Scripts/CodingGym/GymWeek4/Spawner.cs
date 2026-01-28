using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public Vector2 pos;
    public GameObject prop;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos.x = Random.Range(-10f, 10f);
        pos.y = Random.Range(-5f, 5f);
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Spawn();
            Instantiate(prop, transform.position, transform.rotation);
        }
    }

    public void Spawn()
    {
        transform.position = pos;
        Instantiate(prop, transform.position, transform.rotation);
    }
}
