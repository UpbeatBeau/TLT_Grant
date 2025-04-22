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
    public int page;
    public string room = "main";
    public GameObject checklist;
    //public GameObject objectives;
    private ExperienceManager em;
    public int maxpage;
    

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
        if (em.game1 == true && em.game2 == true && em.game3 == true && em.game4 == true)
        {
            switch (room)
            {
                case "main":
                    maxpage = 1;
                    switch (page)
                    {
                        case 0:
                            words.text = "Welcome to the Time Management Station!\r\n You are going to explore multiple ways to enhance your time management skills today.";
                            break;

                        case 1:
                            words.text = "Let’s start from the calendar. \r\n Please point at the white circle on the floor and push the joystick in your right hand.\r\n";
                            break;


                    }
                    break;
                case "main1":
                    maxpage = 0;
                    switch (page)
                    {
                        case 0:
                            words.text = "Good! \r\n Now lets go to the table to make a to-do list.";
                            break;

                    }
                    break;
                case "main2":
                    maxpage = 0;
                    switch (page)
                    {
                        case 0:
                            words.text = "Great! \r\n Now lets go to the white board to learn about procrastination.";
                            break;


                    }
                    break;
                case "main3":
                    maxpage = 0;
                    switch (page)
                    {
                        case 0:
                            words.text = "Awesome! \r\n Now lets go to the bookshelf to look into solutions to procrastination.";
                            break;


                    }
                    break;
                case "cal":
                    maxpage = 2;
                    switch (page)
                    {
                        case 0:
                            words.text = "Welcome to the Calendar!\r\nLet’s make a plan here with your schedule. \r\n";
                            break;

                        case 1:
                            words.text = "Grab the yellow sticky notes by pushing the middle finger button and place them on your schedule by letting go of the button.";
                            break;

                        case 2:
                            words.text = "When you are finished, click “Exit.”";
                            break;


                    }
                    break;
                case "white":
                    maxpage = 1;
                    switch (page)
                    {
                        case 0:
                            words.text = "Welcome to the Whiteboard! \r\n Please review the white board and  press next using the pointer finger.";
                            break;

                        case 1:
                            words.text = "Click exit when finished.";
                            break;


                    }
                    break;
                case "books":
                    maxpage = 3;
                    switch (page)
                    {
                        case 0:
                            words.text = "Welcome to the bookshelf! \r\n Choose strategies to apply for each situation provided.";
                            break;

                        case 1:
                            words.text = "Grab each book by using your middle finger button, and put it on the shelf of the problem it can fix.";
                            break;

                        case 2:
                            words.text = "No right or wrong answers but remember you can transfer these to your real life!";
                            break;

                        case 3:
                            words.text = "When you are finished, click the exit.";
                            break;

                    }
                    break;
                case "table":
                    maxpage = 4;
                    switch (page)
                    {
                        case 0:
                            words.text = "Welcome to the Project station!\r\n You have six weeks to complete your final paper.  Let’s create a timeline to complete each task in a timely manner.";
                            break;

                        case 1:
                            words.text = "Open the box by pushing the button with your middle finger button. Grab each task in the same way and place them to each week.";
                            break;

                        case 2:
                            words.text = "To separate this paper open the box by grabbing (middle finger button) the lid and moving it to the side. Take out each task by grabbing (middle finger button) the items.";
                            break;

                        case 3:
                            words.text = "Once you place the correct item in the section, the week will turn green.";
                            break;

                        case 4:
                            words.text = "When you finish, click the exit.";
                            break;


                    }
                    break;
            }
        }
        else
        {
            switch (page)
            {
                case 0:
                    words.text = "You did it! You finished all four tasks!";
                    break;

                case 1:
                    words.text = "Take off your headset and exit the experience.";
                    break;


            }
        }
            
       

        if(page == maxpage)
        {
           
            nextbut.SetActive(false);
            closebut.SetActive(true);
            checklist.SetActive(true);
        }
        else
        {
            closebut.SetActive(false);
            nextbut.SetActive(true);
        }

        if (page == 0)
        {
            prevbut.SetActive(false);
            //readme.enabled = true;
        }
        else
        {
            prevbut.SetActive(true);
            readme.enabled = false;
        }
    }
    public void Pageturn()
    {
        if (page < maxpage)
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
        //checklist.SetActive(true);
        //objectives.SetActive(true);
    }
}
