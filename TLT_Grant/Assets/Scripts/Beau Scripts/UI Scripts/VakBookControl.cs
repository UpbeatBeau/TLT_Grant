using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VakBookControl : MonoBehaviour
{
    //Vars
    private ExperienceManager em;
    public TextMeshProUGUI words;
    public GameObject nextbut;
    public GameObject prevbut;
    public GameObject closebut;
    private int page;
    public int correctslot;
    //public GameObject exitstuff;


    private void Awake()
    {
        //exitstuff.SetActive(false);
        em = ExperienceManager.instance.GetComponent<ExperienceManager>();
        page = 0;
        em.game4 = true;
    }
    private void Update()
    {
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

        if (page == 3)
        {
            nextbut.SetActive(false);
            closebut.SetActive(true);

        }
        else
        {
            nextbut.SetActive(true);
            closebut.SetActive(false);
        }

        if (page == 0)
        {
            prevbut.SetActive(false);
        }
        else
        {
            prevbut.SetActive(true);
        }

        if (correctslot == 6)
        {
            //exitstuff.SetActive(true);
        }
    }
    public void Pageturn()
    {
        if (page < 3)
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
        this.GetComponentInParent<MeshRenderer>().enabled = false;
        this.GetComponent<Canvas>().enabled = false;
    }

    public void GameDone()
    {
        em.gamecomp++;
    }
}
