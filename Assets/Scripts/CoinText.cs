using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinText : MonoBehaviour
{
    //Variable to assign a TextMeshProUGUI for the script to change
    private TextMeshProUGUI text;
    
    void Start()
    {
        //Looks for a TextMeshProUGUI component on object which the script is on. If there is one it sets the text variable to that component.
        text = GetComponent<TextMeshProUGUI>();
    }

    
    void Update()
    {
        //Tells the text what to say and also refrences the score variable in the Coin script. 
        //This makes it so when we get a coin in the game the number within this part {} gets changed accordingly.
        text.text = string.Format("Coins: {0} / 3", Coin.score);
    }
}
