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
                words.text = "Welcome to the bookshelf! here you will be given the chance to choose which book fits in which shelf to learn about procrastination.";
                break;

            case 1:
                words.text = "Each shelf is labeled with a reason why procrastination occurs. Likewise each book is labeled with a possible solution";
                break;

            case 2:
                words.text = "using your third finger button, grab the book that has the solution you want and put it on the shelf of the problem it can fix.";
                break;

            case 3:
                words.text = "There are no wrong answers and each shelf can hold up to 4 books.";
                break;

            case 4:
                words.text = "After you place your solutions to the problems on the shelf you are finished! Remember you can use these tools in your real life to help.";
                break;

            case 5:
                words.text = "When you are finished, the exit will be located to your right.";
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
