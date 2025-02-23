using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNumber : MonoBehaviour
{
    //hold an integer for each button 
    public int buttonnum;
    //add the gamemanager
    public GameObject gm;
    private QuizManager qm;

    public void Awake()
    {
        qm = gm.GetComponent<QuizManager>();
    }

    //make a function to add number to the num
    public void numpush()
    {
        qm.num = buttonnum;
    }
}
