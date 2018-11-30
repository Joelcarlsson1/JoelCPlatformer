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

    private Transform playerPos;

    private float playerScale = 0.75f;
    

    //Start does what is in it when you start the game
    void Start()
    {
        // Checks if the object with this script on it has a rigidbody. If it does then it sets the rbody variable to that component
        rbody = GetComponent<Rigidbody2D>();
        playerPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Makes it so when you press the assigned input keys in Unity the player moves that direction with a speed based on the moveSpeed variable.
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

        //When you press the assigned Jump keybind the script checks if the isGrounded variable is true
        //If it is then the player gets pushed into the air with a speed based on the jumpSpeed variable. 
        //If it isn't then it doesn't do anything.
        //The reason why this is needed is to stop the player from jumping while in mid air.
        if (Input.GetButtonDown("Jump"))
        {
            if (groundCheck.touching > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerPos.localScale = new Vector3(-playerScale, playerPos.localScale.y, playerPos.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerPos.localScale = new Vector3(playerScale, playerPos.localScale.y, playerPos.localScale.z);
        }
    }
}
