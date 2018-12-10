using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialLocks : MonoBehaviour
{
    //Variable to disable each lock
    public GameObject locks;
    //Variable to get text information
    public TutorialText text;
    //Variable to know if the plate is pushed
    public PressurePlateScript pressurePlate;
    //Variable to know if the bomb has exploded
    public Bomb bomb;
    //Bool for the first lock
    public bool lock1;
    //Bool for the second lock
    public bool lock2;
    //Bool for the third lock
    public bool lock3;
    //Bool for the fourth lock
    public bool lock4;

    // Update is called once per frame
    void Update()
    {
        //If the slide on the text is above or equal to 2 and it is the first lock, it disables the first lock
        if (text.slide >= 2 && lock1 == true)
        {
            locks.SetActive(false);
        }
        //If the pressurePlate is pushed and it is the second lock, it disables the second lock
        if (pressurePlate.pushed == true && lock2 == true)
        {
            locks.SetActive(false);
        }
        //If the bomb has exploded and it is the third lock, it disables the third lock
        if (bomb.exploded == false && lock3 == true)
        {
            locks.SetActive(false);
        }
        //If the tutorial is finished and it is the fourth lock, it disables the fourth lock
        if (text.tutorialFinished == true && lock4 == true)
        {
            locks.SetActive(false);
        }
    }
}
