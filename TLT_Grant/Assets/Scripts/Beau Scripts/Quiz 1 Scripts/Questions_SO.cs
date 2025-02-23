using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make a scriptable object for the questions that has a text, shows which question is next, 
//and shows which is the last question
[CreateAssetMenu (fileName = "NewQuestion", menuName = "Scriptable Objects", order = 0)]
public class Questions_SO : ScriptableObject
{
    //added a bool to see if its an odd number question or not
    public string questiontxt;
    public Questions_SO nextquestion;
    public bool isodd;
    public bool lastquestion;
}
