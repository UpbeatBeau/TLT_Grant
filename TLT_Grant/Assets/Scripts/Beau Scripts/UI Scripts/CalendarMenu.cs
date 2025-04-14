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
        exitstuff.SetActive(false);
        page = 0;
    }
    private void Update()
    {
        switch (page)
        {
            case 0:
                words.text = "Welcome to the Calendar! In this activity you will grab (third finger button) the green sticky notes and place them on your schedule to make a schedule.";
                break;

            case 1:
                words.text = "To place a sticky note grab it, and then place it at the location you want it to go to and let go of the third finger button.";
                break;

            case 2:
                words.text = "You can see you already have Dinner scheduled! Making a schedule is a great way to organize and manage your time.";
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

        if (page == 5)
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

        if(correctslot == 21)
        {
            exitstuff.SetActive(true);
            celebration.SetActive(true);
            em.game1 = true;
            em.gamecomp++;
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
