using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkboxes : MonoBehaviour
{
    private ExperienceManager em;
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;
    public Material Finish;
    

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
    }
}
