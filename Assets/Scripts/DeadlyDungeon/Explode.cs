using UnityEngine;
using UnityEngine.Events;

public class Explode : MonoBehaviour
{
    public GameObject hazardProp;
    public GameObject explosionPrefab;
    public GameObject spawnedExplosion;
    public SpriteRenderer hazard;
    public bool exploded = false;
    public UnityEvent kill;
    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (exploded == false)
        {
            if (hazard.bounds.Contains(transform.position) == true)
            {
                kaboom();
                spawnedExplosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
                t = 0;
                exploded = true;
                kill.Invoke();
            }
        }
        if (t > 4)
        {
            Destroy(spawnedExplosion);
        }
    }

    public void kaboom()
    {
        Destroy(hazardProp);
    }
}
