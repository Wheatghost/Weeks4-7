using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnterSensor;
    public UnityEvent OnExitSensor;
    public UnityEvent<float> OnRandomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hazard.bounds.Contains(transform.position) == true)
        {
            if (isInHazard == true)
            {
                //already in the hazard
            }
            else
            {
                //entered hazard for first time
                Debug.Log("entered the sensor");
                isInHazard = true;
                OnEnterSensor.Invoke();
            }
        }
        else
        {
            if (isInHazard == false)
            {
                //already out of the hazard
            }
            else
            {
                //exited hazard for first time
                isInHazard = false;
                Debug.Log("exited the sensor");
                OnExitSensor.Invoke();
                OnRandomNumber.Invoke(Random.Range(0, 10));
            }
        }
    }

    public void ShowNumber(float number)
    {

    }
}
