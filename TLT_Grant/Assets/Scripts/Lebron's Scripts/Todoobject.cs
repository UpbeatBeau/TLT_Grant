using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Todoobject : MonoBehaviour
{
    //Vars

    public Collider task;
    private bool intrig;
    public InputActionReference leftinput;
    public InputActionReference rightinput;
    public Vector3 moveto;
    public Quaternion movetorot;
    private Vector3 ogpos;
    private Quaternion ogrot;
    private Quaternion rot;
    private RaycastHit hit;
    public bool grippress;
    public bool stupid;
    public string goal;
    public bool beencorrect;
    public TodoController tdc;



    // Awake is called on spawn

    private void Awake()
    {
        intrig = false;
        ogpos = this.gameObject.transform.position;
        ogrot = this.gameObject.transform.rotation;
        beencorrect = false;

    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (rightinput.action.ReadValue<float>() != 0f || leftinput.action.ReadValue<float>() != 0f)
        {
            grippress = true;
        }
        else
        {
            grippress = false;
        }

        if (grippress == false && intrig)
        {
            Vector3 slotSpace = task.transform.position;

            this.gameObject.transform.position = slotSpace;

            if (task.gameObject.name.Contains(goal) == true && !beencorrect)
            {
                Debug.Log("DID IT");
                tdc.correctslot++;
                task.gameObject.GetComponent<Outline>().OutlineColor = Color.green;
                beencorrect = true;
            }
            else if(task.gameObject.name.Contains(goal) == false && !beencorrect)
            {
                task.gameObject.GetComponent<Outline>().OutlineColor = Color.red;
            }


            if (!stupid)
            {
                this.gameObject.transform.rotation = new Quaternion(0, -1, 0, 1);
            }
            else
            {
                this.gameObject.transform.rotation = ogrot * Quaternion.Euler(new Vector3 (0,0,90)) ;
            }

          

        }
        else if (grippress == false && intrig == false && !beencorrect)
        {
            //this.gameObject.transform.position = ogpos;
            //this.gameObject.transform.rotation = ogrot;
        }

        if (stupid == false)
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, 1000f, Physics.DefaultRaycastLayers, QueryTriggerInteraction.Collide) && hit.collider.CompareTag("Sticky") == false)
            {
                //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.yellow);
                //Debug.Log("Did Hit");
                task = hit.collider;
                intrig = true;

            }
            else
            {

                intrig = false;

            }
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 100, Color.yellow);
        }
        else
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, 1000f, Physics.DefaultRaycastLayers, QueryTriggerInteraction.Collide) && hit.collider.CompareTag("Sticky") == false)
            {
                //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.yellow);
                //Debug.Log("Did Hit");
                task = hit.collider;
                intrig = true;

            }
            else
            {

                intrig = false;

            }
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * 100, Color.yellow);
        }
        //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 100, Color.yellow);
    }

    public void todoSelected()
    {
        if (beencorrect)
        {
            tdc.correctslot--;
            beencorrect = false;
        }
    }
}
