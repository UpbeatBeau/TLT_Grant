using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionControl : MonoBehaviour
{

    //Vars

    private OnClick clickControl;
    public CanvasController controller;

    // Awake is called on spawn

    private void Awake()
    {

        clickControl = this.GetComponent<OnClick>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider task)
    {
        if (task.gameObject.CompareTag("Slot 1"))
        {
        
            Vector3 slotSpace = task.transform.position;
            
            this.gameObject.transform.position = slotSpace;

            clickControl.movable = false;

            controller.event1 = "1. Got ready for school";


 
        }
        else if (task.gameObject.CompareTag("Slot 2"))
        {

            Vector3 slotSpace = task.transform.position;

            this.gameObject.transform.position = slotSpace;

            clickControl.movable = false;

            controller.event2 = "2. Went to the Doctor's Office";

        }
        else if (task.gameObject.CompareTag("Slot 3"))
        {

            Vector3 slotSpace = task.transform.position;

            this.gameObject.transform.position = slotSpace;

            clickControl.movable = false;

            controller.event3 = "3. Took the afternoon class";


        }
        else if (task.gameObject.CompareTag("Slot 4"))
        {

            Vector3 slotSpace = task.transform.position;

            this.gameObject.transform.position = slotSpace;

            clickControl.movable = false;

            controller.event4 = "4. Headed home to have lunch";

        }
        else if (task.gameObject.CompareTag("Slot 5"))
        {

            Vector3 slotSpace = task.transform.position;

            this.gameObject.transform.position = slotSpace;

            clickControl.movable = false;

            controller.event5 = "5. Did homework for class";


        }
        else if (task.gameObject.CompareTag("Slot 6"))
        {

            Vector3 slotSpace = task.transform.position;

            this.gameObject.transform.position = slotSpace;

            clickControl.movable = false;

            controller.event6 = "6. Went to bed for the night";


        }

    }
}
