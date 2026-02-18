using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    //display text that variables
    public TextMeshProUGUI counter;
    public float shots;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //tells the player how many shots they've fired
        counter.text = "Shots fired: " + shots.ToString();
    }

    public void add()
    {
        //adds a shot every time the button is pressed  
        shots++;
    }
}
