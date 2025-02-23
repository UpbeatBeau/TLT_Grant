using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make a scriptable object for the questions that has a text, shows which question is next, 
//and shows which is the last question
[CreateAssetMenu (fileName = "NewQuestion", menuName = "Scriptable Objects", order = 0)]
public class Questions_SO : ScriptableObject
{
    public string questiontxt;
    public Questions_SO nextquestion;
    public bool lastquestion;
}
