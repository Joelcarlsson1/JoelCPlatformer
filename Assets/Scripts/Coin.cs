using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int amount = 1;
    private float spinSpeed = 180;
    public static int score;
    private void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
            Coin.score += amount;
        }
    }
}
