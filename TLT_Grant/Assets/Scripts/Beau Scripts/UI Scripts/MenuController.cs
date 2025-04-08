using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    //Vars
    public TextMeshProUGUI words;
    public Button nextbut;
    public Button prevbut;
    private int page;

    private void Awake()
    {
        page = 0;
    }
    private void Update()
    {
        switch (page)
        {
            case 0:
                words.text = "Welcome to the space to learn time management.\r\nTo help you get started lets go over some basics of VR. \r\n if you want to press a button or activate something you use the trigger the your pointer finger is on \n" +
                    "press the next button to go to the next page.";
                break;

            case 1:
                words.text = "When in VR, if you want to grab or pick something up you should point at it and press the button that your third finger is on\r\n";
                break;

            case 2:
                words.text = "You can even grab this canvas! try it!\r\n In order to hold onto something you must hold onto the button. you can let go of the button to put something down!";
                break;

            case 3:
                words.text = "There are multiple ways to move around the room in VR. you can try walking around yourself, or you can move around with the joystick in your left hand!";
                break;

            case 4:
                words.text = "You also can teleport around the room by pushing the joystick in your right hand away from you and pointing at one of the white circles on the floor!";
                break;

            case 5:
                words.text = "Now that you know the basics you can start the experience by going to the calendar and making a schedule";
                break;
        }

        if(page == 5)
        {
            nextbut.enabled = false;
        }
        else
        {
            nextbut.enabled = true;
        }

        if (page == 0)
        {
            prevbut.enabled = false;
        }
        else
        {
            prevbut.enabled = true;
        }
    }
    public void Pageturn()
    {
        page++;
    }
    public void PageBack()
    {
        page--;
    }
}
