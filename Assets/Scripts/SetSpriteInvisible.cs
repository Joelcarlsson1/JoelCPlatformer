using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
    
}
