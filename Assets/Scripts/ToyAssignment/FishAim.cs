using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FishAim : MonoBehaviour
{
    //Use a slider to control the aim of the fish
    public Vector2 direction = new Vector2 (0f,0f);
    public Vector2 sliderpoint = new Vector2(0f, 0f);
    public GameObject prop;
    public Transform start;
    public Transform propStart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = sliderpoint - (Vector2)start.position;
        transform.up = direction;
    }
    //Spawns the projectile
    public void spawn()
    {
        Instantiate(prop, propStart.position, transform.rotation);
    }

    //sets the rotation value for the fish
    public void fishRotate(float a)
    {
        sliderpoint = new Vector2(a, 0);
    }
}
