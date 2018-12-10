using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerHealth : MonoBehaviour
{
    //Variable for the start hp. Is public so that other scripts can access it.
    public int playerHp;

    //Variable for the current hp of the player
    //Static so that the health counter is the same not matter the level
    public static int currentPlayerHp;

    //Variable to count the deaths of the player
    //Static so that the death counter is the same not matter the level
    public static int deaths;

    private void Start()
    {
        //Sets the current hp to the start hp
        currentPlayerHp = playerHp;
    }
}
