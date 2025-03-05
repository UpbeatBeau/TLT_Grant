using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionControl : MonoBehaviour
{

    //Vars

    private OnClick clickControl;
    public CanvasController controller;
    public Collider task;
    private bool intrig;
    public string obj_txt;

    // Awake is called on spawn

    private void Awake()
    {
        intrig = false;
        clickControl = this.GetComponent<OnClick>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && intrig)
        {
            task.enabled = false;

            if (task.gameObject.CompareTag("Slot 1"))
            {

                //Debug.Log("go");

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                clickControl.movable = false;

                controller.event1 = "1. " + obj_txt;



            }
            else if (task.gameObject.CompareTag("Slot 2"))
            {

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                clickControl.movable = false;

                controller.event2 = "2. " + obj_txt;


            }
            else if (task.gameObject.CompareTag("Slot 3"))
            {

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                clickControl.movable = false;

                controller.event3 = "3. " + obj_txt;



            }
            else if (task.gameObject.CompareTag("Slot 4"))
            {

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                clickControl.movable = false;

                controller.event4 = "4. " + obj_txt;


            }
            else if (task.gameObject.CompareTag("Slot 5"))
            {

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                clickControl.movable = false;

                controller.event5 = "5. " + obj_txt;



            }
            else if (task.gameObject.CompareTag("Slot 6"))
            {

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                clickControl.movable = false;

                controller.event6 = "6. " + obj_txt;



            }
        }

    }

    private void OnTriggerEnter(Collider task1)

    {
        task = task1;
        intrig = true;
    }

    private void OnTriggerExit(Collider other)
    {
        task = null;
        intrig = false;
    }
}
