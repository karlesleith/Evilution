using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    public GameObject theSTAR;
    public bool isMoving;
    public float horizontalMove;
    public float verticalMove;
    public float moveSpeed;
    public float turnSpeed;

    // Update is called once per frame
    void Update()
    {
        //if player is moving do this 
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            isMoving = true;
            //PLAY ANIMATION for RUNNING
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            theSTAR.transform.Rotate(0, horizontalMove, 0);
            theSTAR.transform.Translate(0,0, verticalMove);

        }
        else
        {
            isMoving = false;
        }

        //Implemented basic quickturn
        if (Input.GetKeyDown(KeyCode.M)){
            QuickTurn();
        }


    }




   //VERY BASIC Quickturn
    void QuickTurn()
    {
        theSTAR.transform.Rotate(0, 180, 0);
       // Debug.Log("QuickTurned!");
    }

}
