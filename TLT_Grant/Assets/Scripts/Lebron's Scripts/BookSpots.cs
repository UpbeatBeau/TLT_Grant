using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookSpots : MonoBehaviour
{
    public bool on;
    private Outline outline;
    private void Awake()
    {
        outline = this.gameObject.AddComponent<Outline>();
        outline.OutlineMode = Outline.Mode.OutlineAll;
        outline.OutlineColor = Color.yellow;
        outline.OutlineWidth = 10f;
        outline.enabled = false;
    }
    private void Update()
    {
        if (on) 
        {
            outline.enabled = true;
        }
        else
        {
            outline.enabled = false;
        }
    }
}
