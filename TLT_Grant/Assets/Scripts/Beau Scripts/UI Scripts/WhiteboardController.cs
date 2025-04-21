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

        if (page == 1)
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
        if (page < 1)
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
