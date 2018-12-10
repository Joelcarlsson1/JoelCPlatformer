using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //A variable to change the enemy move speed
    public float speed = 2f;

    //A private variable to change the rigidbody of the sprites within the script
    private Rigidbody2D rbody;

    //A bool variable to change if the enemy is going left or not left
    public bool isLeft = true;
    
    void Start()
    {
        //Assigns the rbody variable the to the rigidbody on the object
        rbody = GetComponent<Rigidbody2D>();
        
    }

    //When the enemy enters a trigger with the tag InvisibleWall it sets the isLeft variable to the the opposite state.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
        {
            isLeft = !isLeft;
        }

    }
    //Does everything inside every frame that the physics happen
    private void FixedUpdate()
    {
        //If the isLeft variable is true then the sprite is set to face left and start moving that direction
        if (isLeft == true)
        {
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }

        //If the isLeft isn't true the sprite is set to face right and start moving that direction.
        else
        {
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
}
