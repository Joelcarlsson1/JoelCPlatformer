using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    //A bool that changes based on if the player is on the ground or not
    public int touching;

    //If the object is on the ground it sets isGrounded to true
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touching = touching + 1;
    }

    //If the object leaves/isn't on another object touching is reduced by one which makes you unable to jump in the PlayerMovement script.
    //OnTriggerExit does stuff inside when you leave the trigger
    private void OnTriggerExit2D(Collider2D collision)
    {
        touching = touching - 1;
    }
}
