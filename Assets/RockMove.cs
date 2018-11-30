using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMove : MonoBehaviour
{
    
    public Transform rock;
    public Transform moveTo;
    public Transform dropLocation;
    public bool isHolding;
    public BoxCollider2D colliderRock;
    
    
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (isHolding == true)
        {
            rock.position = moveTo.position;
        }
        if(isHolding == true && Input.GetKeyDown(KeyCode.F))
        {
            isHolding = false;
            colliderRock.enabled = true;
            rock.position = dropLocation.position;
        }
        
        
        

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            
            if (isHolding == false && Input.GetKeyUp(KeyCode.F))
            {

                    isHolding = true;
                    colliderRock.enabled = false;

            }
        }
      
    }
   
}
