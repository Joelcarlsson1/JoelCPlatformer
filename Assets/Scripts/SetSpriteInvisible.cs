using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{
    
    
    void Start()
    {
        //When the game starts all objects with this script on gets their spriterenderer turned off
        GetComponent<SpriteRenderer>().enabled = false;
    }
    
}
