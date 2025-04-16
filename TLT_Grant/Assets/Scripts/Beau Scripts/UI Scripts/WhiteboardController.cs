using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WhiteboardController : MonoBehaviour
{
    //Vars
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
        exitstuff.SetActive(true);
        page = 0;
    }
    private void Update()
    {
        switch (page)
        {
            case 0:
                words.text = "Welcome to the Whiteboard! In this activity you will read the white board and then press (pointer finger) the button that says next on the board.";
                break;

            case 1:
                words.text = "This white board is all about procrastination and what it means to procrastinate.";
                break;

            case 2:
                words.text = "Once you have finished reading all the information on the white board the exit will appear to the left of the white board.";
                break;

            case 3:
                words.text = "Hope you have fun!";
                break;

           
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
            em.game1 = true;
            em.gamecomp++;
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
}
