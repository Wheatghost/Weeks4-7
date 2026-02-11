using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class FlipTank : MonoBehaviour
{
    Vector2 mousePos;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (mousePos.x >= 0)
        {
            transform.localScale = new Vector3 (1,1,1);
        }
        else if (mousePos.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
