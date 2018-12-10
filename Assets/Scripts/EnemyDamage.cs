using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyDamage : MonoBehaviour
{
    //Variable for what scene the script should load when it triggers.
    public string sceneLoad = "Scene1";
    //Variable to see how much hp the player has
    public PlayerHealth playerHp;


    private void Update()
    {
        //If you press the P keybind the level reloads and you can try again in case you get stuck
        if (Input.GetKeyDown(KeyCode.P))
        {
            ReloadLevel();
        }
    }
    //Ontriggerenter does everything inside of it when something with a collider enters it.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the player collides with an enemy and it has less than 1 hp the specified scene loads and resets the coin score
        if (collision.tag == "Player" && PlayerHealth.currentPlayerHp <= 1)
        {
            Death();
        }
        //If the player collides the enemy and has more or equal to 2 hp the player loses 1 hp
        if (collision.tag == "Player" && PlayerHealth.currentPlayerHp >= 2)
        {
            PlayerHealth.currentPlayerHp -= 1;
        }
    }
    //If the player collides with an enemy and it has less than 1 hp the specified scene loads and resets the coin score
    void Death()
    {
        SceneManager.LoadScene(sceneLoad);
        Coin.score = 0;
        PlayerHealth.currentPlayerHp = playerHp.playerHp;
        PlayerHealth.deaths += 1;

    }
    //If you press the P keybind the level reloads and you can try again in case you get stuck
    void ReloadLevel()
    {
        SceneManager.LoadScene(sceneLoad);
        Coin.score = 0;
        PlayerHealth.currentPlayerHp = playerHp.playerHp;

    }
}
