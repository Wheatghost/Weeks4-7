using UnityEngine;

public class BugScrambler : MonoBehaviour
{
    //duck sprite renderer
    SpriteRenderer ds;
    //checks if this duck has changed already
    float act = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ds = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //scrambles the ducks colour each time it spawns
        changeDuck();
    }
    //scramble the colour of the duck
    public void changeDuck()
    {
        if (act == 0)
        {
            ds.color = Random.ColorHSV();
            act = 1;
        }
    }
}
