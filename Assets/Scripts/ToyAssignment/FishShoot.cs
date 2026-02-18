using UnityEngine;

public class FishShoot : MonoBehaviour
{
    //Spawns the waterglob and then shoots it in a straight line
    public GameObject prop;
    float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        //spin the glob in the air
        Vector3 globSpin = transform.eulerAngles; 
        globSpin.z += -0.3f;
        transform.eulerAngles = globSpin;
        //launch the waterglob up and then destroy it after 1 second
        transform.position += transform.up * 10 * Time.deltaTime;
        if (t > 1)
        {
            t = 0;
            Destroy(prop);
        }
    }
}
