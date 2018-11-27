using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour {

    //Variable for what scene the script should load when it triggers.
    public string sceneLoad = "Scene1";
    

    // Variable for what the minimum score should be to trigger
    //It is normally set to zero since you don't need score to die
    public int minimumScoreNeeded = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If specifically the player collides with the object and the score is above or equal to the minimum score needed.
        //If the above is met then it loades the specified scene and sets the score to 0
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            SceneManager.LoadScene(sceneLoad);
            Coin.score = 0;
        }
    }
}
