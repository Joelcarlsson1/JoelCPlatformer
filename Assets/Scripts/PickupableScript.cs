using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableScript : MonoBehaviour
{
    //Transform variable for the pickupable
    public Transform pickupable;
    //Transform variable for where to move the pickupable when it is held
    public Transform moveTo;
    //Transform variable for the drop location
    public Transform dropLocation;
    //Bool variable for if you are holding the object
    public bool isHolding;
    //Collider variable for the pickupable
    public Collider2D colliderPickupable;
    void Update()
    {
        
        //If you are holding the rock it moves the rock to you every frame
        if (isHolding == true)
        {
            pickupable.position = moveTo.position;
        }
        //If you are holding the rock and you press the "F" key the isHolding variable becomes false and the rock is moved to the dropLocation
        //Then the collider for the rock gets turned on
        if(isHolding == true && Input.GetKeyDown(KeyCode.F))
        {
            Pickup();
        }
    }
    
    //Ontriggerstay does everything inside it when a collider stays inside of the object with the script on.
    private void OnTriggerStay2D(Collider2D collision)
    {
        //If an object with the tag "Player" stays in the trigger this happens
        if (collision.tag == "Player")
        {
            Drop();
        }
    }

    //If you are holding the rock and you press the "F" key the isHolding variable becomes false and the rock is moved to the dropLocation
    //Then the collider for the rock gets turned on
    void Pickup()
    {
        isHolding = false;
        pickupable.position = dropLocation.position;
        colliderPickupable.enabled = true;

    }

    void Drop()
    {
        //If the player isn't holding the rock and presses the "F" key isHolding gets set to true and the collider gets disabled
        if (isHolding == false && Input.GetKeyUp(KeyCode.F))
        {
            isHolding = true;
            colliderPickupable.enabled = false;
        }
    }
}
