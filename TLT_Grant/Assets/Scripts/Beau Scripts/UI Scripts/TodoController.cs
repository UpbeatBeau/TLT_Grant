using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TodoController : MonoBehaviour
{
    //Vars
    public TextMeshPro youwin;
    public TextMeshProUGUI words;
    public GameObject nextbut;
    public GameObject prevbut;
    public GameObject closebut;
    private int page;
    public int correctslot;
    public GameObject exitstuff;
    private ExperienceManager em;


    private void Awake()
    {
        em = ExperienceManager.instance.GetComponent<ExperienceManager>();
        youwin.enabled = false;
        exitstuff.SetActive(false);
        page = 0;
    }
    private void Update()
    {
        switch (page)
        {
            case 0:
                words.text = "Welcome to the table. You have five weeks to complete your final paper. Use the provided tasks to create a timeline and assign each task to a specific time frame.";
                break;

            case 1:
                words.text = "In order to complete a large task, we can make a to-do list by separating when to do tasks and prioritizing smaller, more manageable tasks.";
                break;

            case 2:
                words.text = "To separate this paper open the box by grabbing (third finger button) the lid and moving it to the side. Take out each task by grabbing (third finger button) the items.";
                break;

            case 3:
                words.text = "Organize each task on the table by placing them in the section marked on the table. Each week will only have one task assigned to it.";
                break;

            case 4:
                words.text = "Once you place the correct item in the section the week will turn green!";
                break;

            case 5:
                words.text = "After you create a working to-do list by separating the larger project into smaller ones, the exit will appear to your right.";
                break;
        }

        if (page == 5)
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
        }
        else
        {
            prevbut.SetActive(true);
        }

        if (correctslot == 5)
        {
            exitstuff.SetActive(true);
            youwin.enabled = true;
            em.game2 = true;
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

    public void CloseHelp()
    {
        this.GetComponentInParent<MeshRenderer>().enabled = false;
        this.GetComponent<Canvas>().enabled = false;
    }
}
