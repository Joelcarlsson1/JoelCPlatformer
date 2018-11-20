using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rbody;
    public bool left = true;
    public GroundChecker check;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        left = !left;

    }
    private void FixedUpdate()
    {
        
        if (left == true)
        {
            rbody.MovePosition(rbody.position + (-(Vector2)transform.right * Time.deltaTime * speed));
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.MovePosition(rbody.position + ((Vector2)transform.right * Time.deltaTime * speed));
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (check.isGrounded == false)
        {
            left = !left;
        }
    }
}
