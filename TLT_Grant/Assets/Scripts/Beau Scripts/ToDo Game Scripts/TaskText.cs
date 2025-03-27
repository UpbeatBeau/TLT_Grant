using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskText : MonoBehaviour
{
    //Vars
    private TextMeshPro taskName;
    private string startTxt;
    public string finTask;

    private void Awake()
    {
        startTxt = this.transform.name;
        taskName = this.GetComponentInChildren<TextMeshPro>();
        taskName.text = startTxt;
    }
   
    public void TaskFull()
    {
        taskName.text = finTask;
    }
    public void ClearTask()
    {
        taskName.text = startTxt;
    }
}
