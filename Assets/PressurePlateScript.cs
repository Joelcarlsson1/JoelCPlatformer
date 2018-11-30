using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateScript : MonoBehaviour
{
    public BoxCollider2D triggerCollider;
    public BoxCollider2D doorToOpen;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pickupable")
        {
            doorToOpen.isTrigger = true;
            
        }
    }
}
