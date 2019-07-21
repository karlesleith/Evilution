using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1 : MonoBehaviour
{
    public GameObject cameraOne;
    public GameObject cameraTwo;
    public bool on = false;

    public int camNum;

    // Start is called before the first frame update
    void Start()
    {
        camNum = 1;

    }

    

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("HIT");
        if (other.tag == "Player")
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(true);

       

        }
    }


}
