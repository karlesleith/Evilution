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
        StartCoroutine(SwitchCamera());
    }

    IEnumerator SwitchCamera()
    {
        yield return new WaitForSeconds(3);
        cameraTwo.SetActive(true);//turn on camera 2
        cameraOne.SetActive(false);//turn off camera 1
        on = true;
        camNum = 2;

        yield return new WaitForSeconds(3);
        cameraTwo.SetActive(false);//turn on camera 2
        cameraOne.SetActive(true);//turn off camera 1
        on = false;
        camNum = 1;

    }


}
