using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    private Vector3 startPosition; // created a vector3 called start Postion

    private void Awake() // watched a tutorial and not sure what this does yet
    {
        startPosition = transform.position;// this will return our postion back to the beginning start postion of the game
    }

    void Start()// created void called start that will start once before update
    {
        
    }

    void FixedUpdate()// this is a fixed update  
    {
        if (Input.GetKey("space"))// beginning of if statement that will collect userinput if they press the space bar
        {
            transform.position = startPosition;// this will change the postion of our game object back to the beginning postion of the game
            print("Reset position"); // this will print the following text in the console to tell us it has worked
        }// end if
    }//end update
}// end class
