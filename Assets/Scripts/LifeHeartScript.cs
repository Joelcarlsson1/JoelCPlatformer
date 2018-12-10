using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHeartScript : MonoBehaviour
{
    //Variable to see playerhp
    public PlayerHealth player;
    //Sprite for the first heart
    public SpriteRenderer heart1;
    //Sprite for the second heart
    public SpriteRenderer heart2;
    //Sprite for the third heart
    public SpriteRenderer heart3;

    // Update is called once per frame
    void Update()
    {
        //If the player has lost one hp the third heart gets disabled
        if (PlayerHealth.currentPlayerHp == player.playerHp - 1)
        {
            heart3.enabled = false;
        }
        //If the player has lost two hp the second heart gets disabled
        if (PlayerHealth.currentPlayerHp == player.playerHp - 2)
        {
            heart2.enabled = false;
        }
        //If the player has lost three hp the first heart gets disabled
        if (PlayerHealth.currentPlayerHp == player.playerHp - 3)
        {
            heart1.enabled = false;
        }
    }
}
