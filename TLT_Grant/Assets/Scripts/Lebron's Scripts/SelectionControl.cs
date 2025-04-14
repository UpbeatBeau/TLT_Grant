using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class SelectionControl : MonoBehaviour
{

    //Vars

    private OnClick clickControl;
    public CanvasController controller;
    public CalendarMenu calendarMenu;
    public Collider task;
    public bool intrig;
    public string obj_txt;
    public InputActionReference leftinput;
    public InputActionReference rightinput;
    public TextMeshPro stickertxt;
    private bool exiting;
    private Vector3 ogpos;
    private Quaternion ogrot;
    private Quaternion placerot = new Quaternion (0, 0.707106829f, 0, -0.707106829f);
    private RaycastHit hit;
    public string goalslot;
    private bool beencorrect;
    Outline outline;
    
    public bool grippress;

    

    // Awake is called on spawn

    private void Awake()
    {
        intrig = false;
        clickControl = this.GetComponent<OnClick>();
        stickertxt.text = obj_txt;
        exiting = false;
        ogpos = this.gameObject.transform.position;
        ogrot = this.gameObject.transform.rotation;
        beencorrect = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        outline = this.gameObject.AddComponent<Outline>();
        outline.enabled = false;
        outline.OutlineColor = Color.white;
        outline.OutlineMode = Outline.Mode.OutlineAll;
        outline.OutlineWidth = 6;

    }

    // Update is called once per frame
    void Update()
    {
        if(rightinput.action.ReadValue<float>() != 0f || leftinput.action.ReadValue<float>() != 0f)
        {
            grippress = true;
        }
        else
        {
            grippress = false;
        }
        
        if (grippress == false && intrig)
        {
            //task.enabled = false;
            if (task.gameObject.name.Contains(goalslot) == true && !beencorrect)
            {
                calendarMenu.correctslot++;
                beencorrect= true;
                outline.enabled = true;
                outline.OutlineColor = Color.green;
            }else if (task.gameObject.name.Contains(goalslot) == false && beencorrect)
            {
                calendarMenu.correctslot--;
                beencorrect = false;
                outline.enabled = true;
                outline.OutlineColor = Color.red;  
            }else if (task.gameObject.name.Contains(goalslot) == false && !beencorrect)
            {
                outline.enabled = true;
                outline.OutlineColor = Color.red;
            }else if (task.gameObject.name.Contains(goalslot) == false && beencorrect)
            {
                outline.enabled = true;
                outline.OutlineColor = Color.green;
            }

            if (task.gameObject.CompareTag("Slot 1"))
            {

                //Debug.Log("go");

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                this.gameObject.transform.rotation =  placerot;
            }
           
        }else if(grippress == false && intrig == false)
        {
           this.gameObject.transform.position = ogpos;
           this.gameObject.transform.rotation = ogrot;
            if(beencorrect == true)
            {
                controller.correctslot--;
                beencorrect = false;
            }
        }

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, 1000,Physics.DefaultRaycastLayers, QueryTriggerInteraction.Collide) && hit.collider.CompareTag("Sticky") == false){
           // Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * hit.distance, Color.yellow);
           // Debug.Log("Did Hit");
            task = hit.collider;
            intrig = true;
        }
        else
        {
            intrig = false;
        }

        //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * 1000, Color.yellow);
        //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * hit.distance, Color.yellow);




        /*if (Input.GetMouseButtonUp(0) && intrig)
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
        }*/

    }

    /*private void OnTriggerEnter(Collider task1)

    {
        if (intrig==false)
        {
           // Debug.Log("Enter");
            task = task1;
            intrig = true;
            exiting = true;
        }
        else if (intrig==true) 
        {
            //Debug.Log("Transition");
            intrig = false;
            task = null;
            task = task1;
            intrig = true;
            exiting = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (exiting == true)
        {
            //Debug.Log("Exit");
            task = null;
            intrig = false;
            exiting = false;
        }else if (exiting == false)
        {
            exiting = true;
        }
        
    }*/

    public void Clearline()
    {
        outline.enabled = false;
    }
}
