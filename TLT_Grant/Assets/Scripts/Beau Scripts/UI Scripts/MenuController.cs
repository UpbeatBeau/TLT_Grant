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
    public GameObject closebut;
    private int page;
    public GameObject checklist;
    public GameObject objectives;
    private ExperienceManager em;
    

    private void Awake()
    {
        checklist.SetActive(false);
        page = 0;
        
        
    }
    private void Start()
    {
        em = ExperienceManager.instance.GetComponent<ExperienceManager>();
    }
    private void Update()
    {
        if (em.gamecomp == 0)
        {
            switch (page)
            {
                case 0:
                    words.text = "Welcome to the Time Management Station!\r\n You are going to explore multiple ways to enhance your time management skills today.";
                    break;

                case 1:
                    words.text = "Let’s start from the calendar. \r\n Please point at the white circle on the floor and push the joystick in your right hand.\r\n";
                    break;

                /*case 2:
                    words.text = "You can even grab this canvas! Try it!\r\n In order to hold onto something you must hold onto the button. You can let go of the button to put something down!";
                    break;

                case 3:
                    words.text = "There are multiple ways to move around the room in VR. You can try walking around yourself, or you can move around with the joystick in your left hand.";
                    break;

                case 4:
                    words.text = "You also can teleport around the room by pushing the joystick in your right hand away from you and pointing at one of the white circles on the floor and then letting go once the line turns green!";
                    break;

                case 5:
                    words.text = "Now that you know the basics you can start the experience by going to the calendar on the back wall and making a schedule! Always look for these floating tablets for help!";
                    break;*/
            }
        }
        else
        {
            page = 1;
            CloseHelp();
        }

        if(page == 1)
        {
            nextbut.SetActive(false);
            closebut.SetActive(true);
        }
        else
        {
            closebut.SetActive(false);
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
        if (page < 1)
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

        if(this.GetComponentInParent<Tablettoface>().active == false)
        {
            this.GetComponentInParent<Tablettoface>().active = true;
        }
      
    }
    public void CloseHelp()
    {
     
        this.GetComponentInParent<Tablettoface>().active = false;
        //this.GetComponent<Canvas>().enabled = false;
        checklist.SetActive(true);
        objectives.SetActive(true);
    }
}
