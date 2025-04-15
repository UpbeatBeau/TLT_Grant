using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checkboxes : MonoBehaviour
{
    private ExperienceManager em;
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;
    public Material Finish;
    public TextMeshPro words;
    

    private void Awake()
    {
        em = ExperienceManager.instance.GetComponent<ExperienceManager>();
    }
    private void Update()
    {
       if(em.game1 == true)
        {
            g1.GetComponent<MeshRenderer>().material = Finish;
        }
        if (em.game2 == true)
        {
            g2.GetComponent<MeshRenderer>().material = Finish;
        }
        if (em.game3 == true)
        {
            g3.GetComponent<MeshRenderer>().material = Finish;
        }
        if (em.game4 == true)
        {
            g4.GetComponent<MeshRenderer>().material = Finish;
        }
        if (em.game1 == true && em.game2 == true && em.game3 == true && em.game4 == true)
        {
            words.text = "YOU DID IT!!!!\n\n\n You finished the experience by learning how to make a schedule, how to separate smaller projects into a todo list, and how to beat procrastination. \n\n Feel free to take off your VR helmet!";
            g1.gameObject.SetActive(false);
            g2.gameObject.SetActive(false);
            g3.gameObject.SetActive(false);
            g4.gameObject.SetActive(false);
        }
    }
}
