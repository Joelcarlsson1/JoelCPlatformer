using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    //An int variable for how many objects the player is touching
    public int touching;

    //Ontriggerenter does everything inside of it when something with a collider enters it.
    //If the object is on the ground it adds one to the touching variable
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            touching = touching + 1;
        }
            
    }

    //If the object leaves/isn't on another object touching is reduced by one which makes you unable to jump in the PlayerMovement script.
    //OnTriggerExit does stuff inside when you leave the trigger
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            touching = touching - 1;
        }
    }
}
