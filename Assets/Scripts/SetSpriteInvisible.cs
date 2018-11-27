using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {
        //When the game starts all objects with this script on gets their spriterenderer turned off
        GetComponent<SpriteRenderer>().enabled = false;
    }
    
}
