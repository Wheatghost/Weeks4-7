using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MoveDucky : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
            //was the mouse clicked while not over a button?
            if (Mouse.current.leftButton.wasPressedThisFrame == true && EventSystem.current.IsPointerOverGameObject() == false)
            {
                //Y: Set the position to the mouse
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
                transform.position = mousePos;
            }   
    }
}
