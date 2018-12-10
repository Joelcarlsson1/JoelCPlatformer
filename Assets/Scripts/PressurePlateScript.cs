using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateScript : MonoBehaviour
{
    //Variable for the part of the Pressureplate that is a trigger
    public BoxCollider2D triggerCollider;
    //Variable for what door to open
    public BoxCollider2D doorToOpen;
    //Bool for if the plate is pushed
    public bool pushed;

    private void OnTriggerStay2D(Collider2D collision)
    {
        //If an object with the tag "Pickupable" enters the trigger the door get's it's collider turned into a trigger
        //The push variable also gets enabled
        if (collision.tag == "Pickupable")
        {
            doorToOpen.isTrigger = true;
            pushed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //If the rock leaves the plate the door isnt a trigger anymore and the pushed gets set to false
        if (collision.tag == "Pickupable")
        {
            doorToOpen.isTrigger = false;
            pushed = false;
        }
        
    }
}
