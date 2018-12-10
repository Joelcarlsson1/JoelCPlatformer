using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVerticalMovement : MonoBehaviour {

    //A variable to change the enemy move speed
    public float verticalSpeed = 2f;

    //A private variable to change the rigidbody of the sprites within the script
    private Rigidbody2D rbody;

    //A bool variable to change if the enemy is going up or not
    public bool isUp = true;

    void Start()
    {
        //Assigns the rbody variable the to the rigidbody on the object
        rbody = GetComponent<Rigidbody2D>();

    }

    //When the enemy enters a trigger with the tag InvisibleWall it sets the isUp variable to the the opposite state.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
        {
            isUp = !isUp;
        }

    }
    //Does everything inside every frame that the physics happen
    private void FixedUpdate()
    {
        //If the isUp variable is true then the sprite starts moving that direction
        if (isUp == true)
        {
            rbody.velocity = -(Vector2)transform.up * verticalSpeed;
            transform.localScale = new Vector3(1, 1, 1);
        }

        //If the isUp variable isn't true then the sprite starts moving that direction
        else
        {
            rbody.velocity = (Vector2)transform.up * verticalSpeed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    }
