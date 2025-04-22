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
    private int maxpage;
    

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


                }break;
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

                        /*case 3:
                            words.text = "Once you put all the sticky notes in the correct time slots, the Exit will open up!";
                            break;

                        case 4:
                            words.text = "Making sure to schedule your day will keep you on top of tasks.";
                            break;

                        case 5:
                            words.text = "Check here to see your progress." + "\n You have: " + correctslot + " scheduled events correct!";
                            break;*/
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

                        /*case 2:
                            words.text = "Once you have finished reading all the information on the white board the exit will appear to the left of the white board.";
                            break;

                        case 3:
                            words.text = "Hope you have fun!";
                            break;*/


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

                        /*case 4:
                            words.text = "There are no wrong answers and there are enough of each book to put one on each shelf.";
                            break;

                        case 5:
                            words.text = "Remember these skills can transfer to your real life too! When you are finished, the exit will be located to your right.";
                            break;*/
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

                        /* case 5:
                             words.text = "After you create a working to-do list by separating the larger project into smaller ones, the exit will appear to your right.";
                             break;*/
                }
                break;
        }
            
       

        if(page == maxpage)
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
        checklist.SetActive(true);
        //objectives.SetActive(true);
    }
}
