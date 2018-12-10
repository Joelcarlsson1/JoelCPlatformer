using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //Variable so that the script knows that to move when you enter the door
    public Transform player;

    //Variable to set the next location when entering the door
    public Transform nextLocation;

    //Spriterenderer for the current sprite of the door
    private SpriteRenderer door;
    //Spriterenderer for the open sprite of the door
    public SpriteRenderer openDoor;
    //Spriterenderer for the closed sprite of the door
    public SpriteRenderer closedDoor;
    //Variable to be able to call on pressurePlate variables
    public PressurePlateScript pressurePlate;
    

    
    private void Start()
    {
        //Sets the door variable to the spriterenderer on the door
        door = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        //If the doorOpen variable from the pressureplate script is true then the door Sprite is set to the openDoor sprite
        if (pressurePlate.pushed == true)
        {
            door.sprite = openDoor.sprite;
        }
        //If the doorOpen variable from the pressureplate script is false then the door Sprite is set to the closedDoor sprite
        if (pressurePlate.pushed == false)
        {
            door.sprite = closedDoor.sprite;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If an object with the tag "Player" enters the trigger of the door it sets the player location to the nextLocation position
        if (collision.tag == "Player")
        {
            player.position = nextLocation.position;
        }
    }
}
