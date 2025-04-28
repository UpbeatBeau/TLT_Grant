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
    public GameObject openbut;
    public int page;
    public string room = "main";
    public GameObject checklist;
    //public GameObject objectives;
    private ExperienceManager em;
    public int maxpage;
    public bool active;


    

    private void Awake()
    {
        //checklist.SetActive(false);
        page = 0;
        openbut.SetActive(false);
        
    }
    private void Start()
    {
        em = ExperienceManager.instance.GetComponent<ExperienceManager>();
    }
    private void Update()
    {
        if (em.game1 == true && em.game2 == true && em.game3 == true && em.game4 == true && room == "main")
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
        else
        {
            switch (room)
            {
                case "main":
                    maxpage = 1;
                    if (active)
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Welcome to the Time Management Station!\r\n You are going to explore multiple ways to enhance your time management skills today. \r \n To click on buttons in the experience use the trigger button that your pointer finger is on.";
                                break;

                            case 1:
                                words.text = "Let’s start from the calendar on the back wall. \r\n Please point at the white circle on the floor and push the joystick in your right hand forward.\r\n";
                                break;


                        }
                    }
                    else
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Welcome to the Time Management Station!";
                                break;

                            case 1:
                                words.text = "Let’s start from the calendar.";
                                break;


                        }
                    }
                        break;
                case "main1":
                    maxpage = 0;
                    if (active)
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Good! \r\n Now lets go to the table to make a to-do list.";
                                break;

                        }
                    }
                    else
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Go to the table.";
                                break;

                        }
                    }
                    break;
                case "main2":
                    maxpage = 0;
                    if (active)
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Great! \r\n Now lets go to the white board to learn about procrastination.";
                                break;


                        }
                    }
                    else
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Go to the white board.";
                                break;


                        }
                    }
                    break;
                case "main3":
                    maxpage = 0;
                    if (active)
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Awesome! \r\n Now lets go to the bookshelf to look into solutions to procrastination.";
                                break;


                        }
                    }
                    else
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Go to the bookshelf.";
                                break;


                        }
                    }
                    break;
                case "cal":
                    maxpage = 2;
                    if (active)
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Welcome to the Calendar!\r\nLet’s make a plan here with your schedule. \r\n";
                                break;

                            case 1:
                                words.text = "Grab the yellow sticky notes by pushing the middle finger button on the grip and place them on your schedule by letting go of the button. You may want to walk closer to the board.";
                                break;

                            case 2:
                                words.text = "When you are finished, click exit on your right.";
                                break;


                        }
                    }
                    else
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Welcome to the Calendar!";
                                break;

                            case 1:
                                words.text = "Grab the yellow sticky notes";
                                break;

                            case 2:
                                words.text = "Place sticky notes on the board in the correct time. When you are finished, click “Exit.”";
                                break;


                        }
                    }
                    break;
                case "white":
                    maxpage = 1;
                    if (active)
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Welcome to the Whiteboard! \r\n Please review the white board and press next using the pointer finger on the trigger.";
                                break;

                            case 1:
                                words.text = "Click exit on your right when finished.";
                                break;


                        }
                    }
                    else
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Welcome to the Whiteboard!";
                                break;

                            case 1:
                                words.text = "Click next button to go through the slides. Click exit when finished.";
                                break;


                        }
                    }
                    break;
                case "books":
                    maxpage = 3;
                    if (active)
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Welcome to the bookshelf! \r\n Choose strategies to apply for each situation provided.";
                                break;

                            case 1:
                                words.text = "Grab each book by using your middle finger button on the grip, and put it on the shelf of the problem it can fix.";
                                break;

                            case 2:
                                words.text = "No right or wrong answers, but remember you can transfer these to your real life!";
                                break;

                            case 3:
                                words.text = "When you are finished, click the exit on the right.";
                                break;

                        }
                    }
                    else
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Welcome to the bookshelf!";
                                break;

                            case 1:
                                words.text = "Grab each book , and put it on a shelf.";
                                break;

                            case 2:
                                words.text = "No right or wrong answers.";
                                break;

                            case 3:
                                words.text = "Put books on the shelves. When you are finished, click the exit.";
                                break;

                        }
                    }
                    break;
                case "table":
                    maxpage = 3;
                    if (active)
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Welcome to the Project station!\r\n You have six weeks to complete your final paper.  Let’s create a timeline to complete each task in a timely manner.";
                                break;

                            case 1:
                                words.text = "The box is open for you already. Grab each floating task by using your middle finger button on the grip and place them to each week.";
                                break;

                            case 2:
                                words.text = "Once you place the correct item in the section, the week will turn green.";
                                break;

                            case 3:
                                words.text = "When you finish, click the exit on the right.";
                                break;
                        }
                    }
                    else
                    {
                        switch (page)
                        {
                            case 0:
                                words.text = "Welcome to the Project station!";
                                break;

                            case 1:
                                words.text = "Grab each task and place them to a week.";
                                break;

                            case 2:
                                words.text = "The correct section will turn green.";
                                break;

                            case 3:
                                words.text = "When all the sections are green, click the exit.";
                                break;
                        }
                    }
                    break;
            }
            
        }
            
       

        if(page == maxpage)
        {
            if (active)
            {
                nextbut.SetActive(false);
                closebut.SetActive(true);
                openbut.SetActive(false);
            }
            else
            {
                nextbut.SetActive(false);
                openbut.SetActive(true);
            }
            //checklist.SetActive(true);
        }
        else
        {
            closebut.SetActive(false);
            nextbut.SetActive(true);
            openbut.SetActive(false);
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

       
      
    }
    public void CloseHelp()
    {
     
        this.GetComponentInParent<Tablettoface>().active = false;
        closebut.SetActive(false);
        openbut.SetActive(true);
        active = false;
        //this.GetComponent<Canvas>().enabled = false;
        //checklist.SetActive(true);
        //objectives.SetActive(true);
    }

    public void Activate()
    {
        this.GetComponentInParent<Tablettoface>().active = true;
        page = 0;
        nextbut.SetActive(true);
        closebut.SetActive(false);
        openbut.SetActive(false);
        active = true;
    }
}
