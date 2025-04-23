using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CalendarMenu : MonoBehaviour
{
    //Vars
    public TextMeshProUGUI words;
    public GameObject nextbut;
    public GameObject prevbut;
    private int page;
    public int correctslot;
    public GameObject exitstuff;
    public GameObject celebration;
    private ExperienceManager em;


    private void Awake()
    {
        em = ExperienceManager.instance.GetComponent<ExperienceManager>();
        exitstuff.SetActive(true);
        page = 0;
    }
    private void Update()
    {
        /*switch (page)
        {
            case 0:
                words.text = "Welcome to the Calendar!\r\nLet’s make a plan here with your schedule. \r\n";
                break;

            case 1:
                words.text = "Grab the green sticky notes by pushing the middle finger button and place them on your schedule by letting go of the button.";
                break;

            case 2:
                words.text = "When you are finished, click “Exit.”";
                break;

            case 3:
                words.text = "Once you put all the sticky notes in the correct time slots, the Exit will open up!";
                break;

            case 4:
                words.text = "Making sure to schedule your day will keep you on top of tasks.";
                break;

            case 5:
                words.text = "Check here to see your progress." + "\n You have: " + correctslot + " scheduled events correct!";
                break;
        }

        if (page == 2)
        {
            nextbut.SetActive(false);
            
        }
        else
        {
            nextbut.SetActive(true);
        }

        if (page == 0)
        {
            prevbut.SetActive(false);
        }
        else
        {
            prevbut.SetActive(true);
        }
        */
        if(correctslot == 21)
        {

            FINISH();
        }

       
    }
    public void Pageturn()
    {
        if (page < 2)
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

    public void FINISH()
    {
        celebration.SetActive(true);
        em.game1 = true;
        em.gamecomp++;
    }
}
