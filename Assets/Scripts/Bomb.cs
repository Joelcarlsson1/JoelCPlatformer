using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    //Variable to control the GameObject component of the bomb
    public GameObject bomb;
    //Variable to control the GameObject component of the explosion
    public GameObject explosionParticle;
    //Variable to be able to call on variables from destroyArea
    public DestroyAreaScript destroyArea;
    //Bool for if the bomb has exploded or not
    public bool exploded = false;
    
    void Update()
    {
        //if the destroy variable from destroyArea script is true the explosion will start and exploded will be set to true
        if (destroyArea.destroy == true)
        {
            Explosion();
            exploded = true;
        }
    }

    //Function for the explosion
    void Explosion()
    {
        //if exploded is false the explosion particle is set at the current location of the bomb and the bomb gets disabled
        if (exploded == false)
        {
            Instantiate(explosionParticle, transform.position, transform.rotation);
            bomb.SetActive(false);
            
        }
    }
}
