using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeOutline : MonoBehaviour
{
    //vars
    Outline outline;
    private void Awake()
    {
        outline = this.gameObject.AddComponent<Outline>();
        outline.enabled = true;
        outline.OutlineColor = Color.white;
        outline.OutlineMode = Outline.Mode.OutlineAll;
        outline.OutlineWidth = 6;
    }
    
    public void OutOFF()
    {
        outline.OutlineColor = Color.white;
        Debug.Log("color");
    }
}
