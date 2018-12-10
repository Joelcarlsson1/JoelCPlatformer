using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Variable for how much score the specific coin gives
    public int amount = 1;

    //The speed which the coin rotates at
    private float spinSpeed = 180;

    //A universal variable for how much score you have. It is static since the score shouldn't be tied to a specific object and instead be the same across all objects.
    public static int score;

    private void Update()
    {
        //Rotates the coin at the assigned spinSpeed
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
        
    }
    //Ontriggerenter does everything inside of it when something with a collider enters it.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If an object with the tag Player enters the collision the coin gets destroyed and it adds one to the score counter.
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            Coin.score += amount;
        }
    }
}
