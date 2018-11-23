using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour
{
    public string sceneLoad = "Scene1";
    public int minimumScoreNeeded = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            SceneManager.LoadScene(sceneLoad);
            Coin.score = 0;
        }
    }
}
