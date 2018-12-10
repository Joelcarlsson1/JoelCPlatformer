using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBombScript : MonoBehaviour
{

    
    //Variable to turn off the locks
    public GameObject locks;
    //Variable for the first pressurePlate
    public PressurePlateScript plate1;
    //Variable for the second pressurePlate
    public PressurePlateScript plate2;


    void Update()
    {
        //If the first and second plates are pushed the locks get disabled
        if (plate1.pushed == true && plate2.pushed == true)
        {
            locks.SetActive(false);
        }
    }

}
