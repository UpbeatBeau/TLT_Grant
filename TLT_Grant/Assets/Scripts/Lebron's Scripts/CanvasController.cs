using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasController : MonoBehaviour
{

    public TextMeshProUGUI eventText;
    private ExperienceManager em;
    public string event1 = "1. ";
    public string event2 = "2. ";
    public string event3 = "3. ";
    public string event4 = "4. ";
    public string event5 = "5. ";
    public string event6 = "6. ";


    private void Awake()
    {
        em = ExperienceManager.instance.GetComponent<ExperienceManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        eventText.text = "Hey there! Welcome to the taskboard." + "\n" + "\n" + "It's a handy little thing that let's us figure out our day." +
           "\n" + "\n" + "Let's try makin' your schedule. Grab and place the green sticky notes on the board" + "\n" + "\n" + event1 + "\n" + event2 + "\n" + event3 + "\n" + event4 + "\n" + event5 + "\n"
           + event6 + "\n";

        if(event1 == "1. Go to Class" && event2 == "2. Feed the Dog" && event3 == "3. Do Homework" && event4 == "4. Dinner with Friends" 
            && event5 == "5. Study" && event6 == "6. Go to Bed")
        {
            eventText.text = "You did it!" + "\n" + "\n" + "What a beautiful schedule you put together"  + "\n" + "\n" + event1 + "\n" + event2 + "\n" + event3 + "\n" + event4 + "\n" + event5 + "\n"
           + event6 + "\n";
            em.game1 = true;
        }
    }

}
