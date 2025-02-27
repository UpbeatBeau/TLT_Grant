using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasController : MonoBehaviour
{

    public TextMeshProUGUI eventText;
    public string event1 = "1. ";
    public string event2 = "2. ";
    public string event3 = "3. ";
    public string event4 = "4. ";
    public string event5 = "5. ";
    public string event6 = "6. ";



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        eventText.text = "Hey there! Welcome to the taskboard." + "\n" + "\n" + "It's a handy little thing that let's us figure out our day." +
           "\n" + "\n" + "Let's try makin' your schedule." + "\n" + "\n" + event1 + "\n" + event2 + "\n" + event3 + "\n" + event4 + "\n" + event5 + "\n"
           + event6 + "\n";
    }
}
