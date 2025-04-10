using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentationController : MonoBehaviour
{
    //vars
    public GameObject nextbut;
    public GameObject prevbut;
    public GameObject donebut;
    public RawImage rawImage;
    public Texture slide1;
    public Texture slide2;
    public Texture slide3;
    private int slidenum;
    public GameObject exitstuff;
    private ExperienceManager em;


    // Start is called before the first frame update
    void Awake()
    {
        em = ExperienceManager.instance.GetComponent<ExperienceManager>();
        exitstuff.SetActive(false);
        slidenum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        switch (slidenum)
        {
            case 1:
                rawImage.texture = slide1;
                break;

            case 2:
                rawImage.texture = slide2;
                break;

            case 3:
                rawImage.texture = slide3;
                break;
        }

        if (slidenum == 3)
        {
            nextbut.SetActive(false);
            donebut.SetActive(true);

        }
        else
        {
            nextbut.SetActive(true);
            donebut.SetActive(false);
        }

        if (slidenum == 0)
        {
            prevbut.SetActive(false);
        }
        else
        {
            prevbut.SetActive(true);
        }


    }
    public void DONEBUT()
    {
        this.gameObject.SetActive(false);
        exitstuff.SetActive(true);
        em.game3 = true;
        em.gamecomp++;
        //rawImage.enabled = false;
       
    }

    public void Pageturn()
    {
        if (slidenum < 3)
        {
            slidenum++;
        }
    }
    public void PageBack()
    {
        if (slidenum > 1)
        {
            slidenum--;
        }

    }
}
