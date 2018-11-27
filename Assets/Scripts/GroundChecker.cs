using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    //A bool that changes based on if the player is on the ground or not
    public bool isGrounded;

    //If the object is on the ground it sets isGrounded to true
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }

    //If the object leaves/isn't on another object isGrounded is set to false which makes you unable to jump in the PlayerMovement script.
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}
