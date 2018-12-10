using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour {

    //Variable for what scene the script should load when it triggers.
    public string sceneLoad = "Scene1";

    // Variable for what the minimum score should be to finish the level
    //It is normally set to zero since not every map needs coins to finish
    public int minimumScoreNeeded = 0;

    //Variable to change the player
    public PlayerHealth player;

    //Ontriggerenter does everything inside of it when something with a collider enters it.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If specifically the player collides with the object and the score is above or equal to the minimum score needed.
        //If the above is met then it loades the specified scene and sets the score to 0
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            Finish();
        }
    }
    void Finish()
    {
        //If specifically the player collides with the object and the score is above or equal to the minimum score needed.
        //If the above is met then it loades the specified scene and sets the score to 0
        SceneManager.LoadScene(sceneLoad);
        Coin.score = 0;
        PlayerHealth.currentPlayerHp = player.playerHp;
    }
}
