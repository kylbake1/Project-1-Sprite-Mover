using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    void Start() // creates a void called start that will update before Update()
    {
     
    }
    public void Update() // creates a public void called update that will update every frame
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //if statement that will collect user input if they press the esc key
        {// begin if
            Application.Quit();// this will close down the application 
            print("Has Quit Game");// this will print the following text in the console to demostate that the application has closed
        }// end if
    }//end void update
}// end of class QuitGame
