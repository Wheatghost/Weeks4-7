using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class AimFire : MonoBehaviour
{
    //script to control turret rotation
    Vector2 mousePos;
    Vector2 direction;
    public GameObject prop;
    public Transform start;
    Transform angle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        direction = mousePos - (Vector2)start.position;
        transform.right = direction;
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            spawn();
        }

    }

    void spawn()
    {
        transform.position = start.position;
        Instantiate(prop, transform.position, transform.rotation);
    }
}
