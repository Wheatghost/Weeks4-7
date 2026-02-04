using UnityEngine;

public class Toggle : MonoBehaviour
{
    public void ToggleMoon()
    {
        gameObject.SetActive(!gameObject.gameObject.activeInHierarchy);

       /* if (gameObject.activeInHierarchy == true)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.activeInHierarchy == false)
        {
            gameObject.SetActive(true);
        }*/

    }

}
