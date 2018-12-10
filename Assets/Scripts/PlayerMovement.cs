using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variable to make movement speed changable in Unity
    public float moveSpeed = 6f;

    //Variable to change jump distance in unity
    public float jumpSpeed = 12f;

    //Variable from the GroundChecker script. Used to stop you from jumping when airborne
    public GroundChecker groundCheck;

    //Private variable which lets this script controll the player sprite's rigidbody.
    private Rigidbody2D rbody;

    //Variable to control the Transform component of the player
    public Transform dropPos;

    
    

    //Start does everything in it when you start the game
    void Start()
    {
        // Checks if the object with this script on it has a rigidbody. If it does then it sets the rbody variable to that component
        rbody = GetComponent<Rigidbody2D>();
        
    }

    //Update does everything inside of it every frame
    void Update()
    {
        //Controls movement
        Movement();

        //When the assigned Jump button is the jump function starts
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        //When the A button is pressed the drop position is set to the left side
        if (Input.GetKeyDown(KeyCode.A))
        {
            WalkLeft();
        }
        //When the D button is pressed the drop position is set to the right side
        if (Input.GetKeyDown(KeyCode.D))
        {
            WalkRight();
        }
    }
    void Jump()
    {
        //When you press the assigned Jump keybind the script checks if the touching variable is above 0
        //If it is then the player gets pushed into the air with a speed based on the jumpSpeed variable. 
        //If it isn't then it doesn't do anything.
        //The reason why this is needed is to stop the player from jumping while in mid air.
        if (groundCheck.touching > 0)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
        }
    }
    //When the A button is pressed the drop position is set to the left side
    void WalkLeft()
    {
        dropPos.localPosition = new Vector3(-1.5f, dropPos.localPosition.y, dropPos.localPosition.z);
    }
    //When the D button is pressed the drop position is set to the right side
    void WalkRight()
    {
        dropPos.localPosition = new Vector3(1.5f, dropPos.localPosition.y, dropPos.localPosition.z);
    }
    void Movement()
    {
        //Makes it so when you press the assigned input keys in Unity the player moves that direction with a speed based on the moveSpeed variable.
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);
    }
}
