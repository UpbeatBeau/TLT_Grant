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
                words.text = "Welcome to the bookshelf! Here you will be given the chance to choose which book fits in which shelf to learn about procrastination.";
                break;

            case 1:
                words.text = "Each shelf is labeled with a situation in which procrastination occurs. Likewise each color of book is labeled with a possible solution.";
                break;

            case 2:
                words.text = "Using your middle finger button, grab the book that has the solution you want and put it on the shelf of the problem it can fix.";
                break;

            case 3:
                words.text = "Based on each situation, choose each book with appropriate coping strategy and place it into each bookshelf.";
                break;

            case 4:
                words.text = "There are no wrong answers and there are enough of each book to put one on each shelf.";
                break;

            case 5:
                words.text = "Remember these skills can transfer to your real life too! When you are finished, the exit will be located to your right.";
                break;
        }

        if (page == 5)
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
    public void CloseHelp()
    {
        this.GetComponentInParent<MeshRenderer>().enabled = false;
        this.GetComponent<Canvas>().enabled = false;
    }
}
