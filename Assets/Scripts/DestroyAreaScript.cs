using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAreaScript : MonoBehaviour {
    //Gameobject variable to control the boxes
    public GameObject boxes;
    //Bool so we know if the bomb has activated the destroy area
    public bool destroy = false;
    //Private variable for how long it is until the explosion
    float bombDelay;
    //Transform variable for the bomb
    public Transform bomb;
    //Bool so we know if the detonation has started or not
    bool detonationStart = false;

    //Update does everything inside it every frame
    private void Update()
    {
        //If the destroy has been completed the boxes get disabled
        if (destroy == true)
        {
            boxes.SetActive(false);
        }
        //If the detonation has started the bombDelay gets increased every real life second
        if (detonationStart == true)
        {
            Detonation();
        }
    }
    //Ontriggerenter does everything inside of it when something with a collider enters it.
    void OnTriggerEnter2D(Collider2D collision)
    {
        //If the object has the tag "Bomb" the detonation starts
        if (collision.tag == "Bomb")
        {
            detonationStart = true;

        }
    }

    public void Detonation()
    {
        //If the detonation has started the bombDelay gets increased every real life second
        bombDelay += Time.deltaTime;
        //If the bombDelay is equal or above 5 destroy gets activated
        if (bombDelay >= 5)
        {
            destroy = true;
        }
        //If the bombDelay is equal or above 2 the bomb grows in scale equal to the bombDelay / 2 every frame
        if (bombDelay >= 2)
        {
            bomb.localScale = new Vector3(bombDelay / 2, bombDelay / 2, bombDelay / 2);
        }
    }

}
