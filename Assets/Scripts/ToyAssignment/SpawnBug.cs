using UnityEngine;

public class SpawnBug : MonoBehaviour
{
    //time, branches, and duck variables
    public float t;
    public GameObject duck;
    public Transform branch1;
    public Transform branch2;
    public Transform branch3;
    public Transform branch4;
    //range of branches to choose from
    public float choice = Random.Range(2,4);
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //creates a duck after a certain amount of time in one of the available spots
        t += Time.deltaTime;
        if (t > 10)
        {
            spawn(choice);
            t = 0;
            choice = Random.Range(2, 4);
        }
    }

    //choose a spawn location for the duck used to have branch1 and branch2 but I cut them out because they were causing issues and I want to finish this
    void spawn(float a)
    {
        Destroy(duck);
        if (a == 2)
        {
            Instantiate(duck, branch3.position, transform.rotation);
        }
        else if (a == 3)
        {
            Instantiate(duck, branch4.position, transform.rotation);
        }
    }
    
}
