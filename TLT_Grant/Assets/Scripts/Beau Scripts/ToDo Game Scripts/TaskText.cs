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
    public GameTxt gt;
    public bool full;

    private void Awake()
    {
        startTxt = this.transform.name;
        taskName = this.GetComponentInChildren<TextMeshPro>();
        taskName.text = startTxt;
        full = false;
    }
   
    public void TaskFull()
    {
        taskName.text = finTask;
        full = true;
        gt.taskCount ++;

    }
    public void ClearTask()
    {
        taskName.text = startTxt;
    }
}
