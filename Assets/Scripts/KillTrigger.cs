using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillTrigger : MonoBehaviour
{
    //Variable for what scene to load
    public string sceneLoad = "Scene1";
    //Variable for the playerHp
    public PlayerHealth playerHp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If a player collides with the killTrigger the scene gets loaded and the everything is reset
        //It also sets the hp to full and adds 1 to the death counter
        if (collision.tag == "Player")
        {
            Death();
        }
    }
    //If a player collides with the killTrigger the scene gets loaded and the everything is reset
    //It also sets the hp to full and adds 1 to the death counter
    void Death()
    {
        SceneManager.LoadScene(sceneLoad);
        Coin.score = 0;
        PlayerHealth.currentPlayerHp = playerHp.playerHp;
        PlayerHealth.deaths += 1;
    }
}
