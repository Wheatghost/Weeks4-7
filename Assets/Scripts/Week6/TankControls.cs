using UnityEngine;
using UnityEngine.InputSystem;

public class TankControls : MonoBehaviour
{
    public float speed = 2;
    Vector2 pos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Speed(1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.aKey.isPressed == true)
        {
            transform.position -= transform.right*speed/120;
        }
        if (Keyboard.current.dKey.isPressed == true)
        {
            transform.position += transform.right*speed/120;
        }
    }
    
    public void Speed(float s)
    {
        speed = s;
    }
}
