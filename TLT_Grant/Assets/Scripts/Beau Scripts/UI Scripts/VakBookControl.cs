using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VakBookControl : MonoBehaviour
{
    //Vars
    public TextMeshProUGUI words;
    public GameObject nextbut;
    public GameObject prevbut;
    private int page;
    public int correctslot;
    //public GameObject exitstuff;


    private void Awake()
    {
        //exitstuff.SetActive(false);
        page = 0;
    }
    private void Update()
    {
        switch (page)
        {
            case 0:
                words.text = "Welcome to the table. In front of you is the large project of writing a research paper in 6 weeks, it may seem like a huge task at first!";
                break;

            case 1:
                words.text = "In order to complete a large task, we can make a to do list by separating when to do tasks and prioritizing smaller, more manageable tasks.";
                break;

            case 2:
                words.text = "To separate this paper open the box by grabbing the lid with your third finger button and take out each task by grabbing the items with your third finger button.";
                break;

            case 3:
                words.text = "Organize each task on the table by placing them in the section marked on the table. Each week will only have one task assigned to it.";
                break;

            case 4:
                words.text = "Once you place the correct item in the section the week will turn green!";
                break;

            case 5:
                words.text = "After you create a working todo list by separating the larger project into smaller ones, the exit will appear to your right.";
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
        this.GetComponentInParent<GameObject>().SetActive(false);
    }
}
