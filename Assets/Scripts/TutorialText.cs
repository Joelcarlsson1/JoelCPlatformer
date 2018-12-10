using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TutorialText : MonoBehaviour
{
    //Variable to be able to change the text
    TextMeshProUGUI text;
    //Variable to know if the plate has been pushed
    public PressurePlateScript pressurePlate;
    //Variable to know if the bomb has exploded
    public Bomb bomb;
    //Variable to change what text is showing. Defaulted to 1 since it is the first slide
    public int slide = 1;
    //Bool for if the player has finished the tutorial
    public bool tutorialFinished = false;

    void Start()
    {
        //Looks for a TextMeshProUGUI component on object which the script is on. If there is one it sets the text variable to that component.
        text = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        //If the slide is 1 information on what to do is displayed
        if (slide == 1)
        {
            text.text = string.Format("Use A and D to move around. Press SPACE to jump. Press E to proceed");
        }

        //If the slide is 2 information on what to do is displayed
        if (slide == 2)
        {
            text.text = string.Format("Press F to pick up stones or bombs. Press F again to drop it in front of you. Take this stone to the pressure plate to continue");
        }

        //If the slide is 3 information on what to do is displayed
        if (slide == 3)
        {
            text.text = string.Format("Find a bomb and drop it near the boxes to blow them up. If you ever get stuck press P to reload the level");
        }

        //If the slide is 4 information on what to do is displayed
        if (slide == 4)
        {
            text.text = string.Format("Avoid these enemies. Failing to do so will make you lose hearts. Also pickup the coins to be able to finish the level. {0} / 5 collected", Coin.score);
        }

        //If the slide is 5 information on what to do is displayed
        if (slide == 5)
        {
            text.text = string.Format("Good job! You completed the tutorial level. Press E to unlock these locks. Then enter the goal to start the first level");
        }

        //If you press E and it is the first slide. The slide gets set to 2
        if(Input.GetKeyDown(KeyCode.E) && slide == 1)
        {
            slide = 2;
        }

        //If the plate is pushed and it is the second slide. The slide gets sets to 3
        if(pressurePlate.pushed == true && slide == 2)
        {
            slide = 3;
        }

        //If the bomb has exploded and it is the third slide. The slide gets sets to 4
        if (bomb.exploded == true && slide == 3)
        {
            slide = 4;
        }

        //If the player has collected 5 or more score and it is the fourth slide. The slide gets sets to 5
        if (Coin.score >= 5 && slide == 4)
        {
            slide = 5;
        }

        //When E is pressed and it is the fifth slide. The tutorialFinished gets set to true
        if (Input.GetKeyDown(KeyCode.E) && slide == 5)
        {
            tutorialFinished = true;
        }

    }
}
