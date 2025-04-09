using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    //Vars
    public TextMeshPro readme;
    public TextMeshProUGUI words;
    public GameObject nextbut;
    public GameObject prevbut;
    private int page;
    public GameObject checklist;
    public GameObject objectives;

    private void Awake()
    {
        checklist.SetActive(false);
        page = 0;
    }
    private void Update()
    {
        switch (page)
        {
            case 0:
                words.text = "Welcome to the space to learn time management.\r\nTo help you get started lets go over some basics of VR. \r\n If you want to press a button or activate something you use the trigger that your pointer finger is on \n" +
                    "Press the next button to go to the next page.";
                break;

            case 1:
                words.text = "When in VR, if you want to grab or pick something up you should point at it and press the button that your third finger is on.\r\n";
                break;

            case 2:
                words.text = "You can even grab this canvas! Try it!\r\n In order to hold onto something you must hold onto the button. You can let go of the button to put something down!";
                break;

            case 3:
                words.text = "There are multiple ways to move around the room in VR. you can try walking around yourself, or you can move around with the joystick in your left hand.";
                break;

            case 4:
                words.text = "You also can teleport around the room by pushing the joystick in your right hand away from you and pointing at one of the white circles on the floor and then letting go once the line turns green!";
                break;

            case 5:
                words.text = "Now that you know the basics you can start the experience by going to the calendar on the back wall and making a schedule! Always look for these floating tablets for help!";
                break;
        }

        if(page == 5)
        {
            nextbut.SetActive(false);
            checklist.SetActive(true);
            objectives.SetActive(true);
        }
        else
        {
            nextbut.SetActive(true);
        }

        if (page == 0)
        {
            prevbut.SetActive(false);
            readme.enabled = true;
        }
        else
        {
            prevbut.SetActive(true);
            readme.enabled = false;
        }
    }
    public void Pageturn()
    {
        if (page < 5)
        {
            page++;
        }
    }
    public void PageBack()
    {
        if (page > 0)
        {
            page--;
        }
      
    }
}
