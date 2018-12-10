using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndGame : MonoBehaviour
{
    //Variable to change the on scren text
    private TextMeshProUGUI text;
    //Variable to get information about the player
    public PlayerHealth player;
    

    void Start()
    {
        //Looks for a TextMeshProUGUI component on object which the script is on. If there is one it sets the text variable to that component.
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        //If the player died 0 times you get a unique ending text
        if (PlayerHealth.deaths == 0)
        {
            text.text = string.Format("Wow, you really are a pro, you didn't die a single time. Well done!");
        }
        //If the player died more than 0 times you get told how many times you died and how much hp you had left
        if(PlayerHealth.deaths > 0)
        {
            text.text = string.Format("Congratulations! You finished the game! You died {0} times and had {1} HP left.", PlayerHealth.deaths, PlayerHealth.currentPlayerHp);
        }
            
    }
}
