using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UIElements;

public class TodoSelection : MonoBehaviour
{

    //Vars

    private bool intrig;
    private bool exiting;
    public InputActionReference leftinput;
    public InputActionReference rightinput;
    public TextMeshPro stickertxt;
    private Vector3 ogpos;
    public Collider task;
    private Rigidbody rb;
    public bool hasmoved;

    public bool grippress;

    private void Awake()
    {
        intrig = false;
        exiting = false;
        ogpos = this.gameObject.transform.position;
        rb = this.gameObject.GetComponent<Rigidbody>();
        hasmoved = false;
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
            grippress= false;
        }
        if ( intrig && rb.velocity == Vector3.zero && grippress == false && hasmoved)
        {
            //task.enabled = false;

            if (task.gameObject.CompareTag("Slot 1"))
            {

                Debug.Log("go");

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                rb.isKinematic = true;

                

               



            }
            else if (task.gameObject.CompareTag("Slot 2"))
            {

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                

                

            }
            else if (task.gameObject.CompareTag("Slot 3"))
            {

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                



            }
            else if (task.gameObject.CompareTag("Slot 4"))
            {

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                


            }
            else if (task.gameObject.CompareTag("Slot 5"))
            {

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

              



            }
            else if (task.gameObject.CompareTag("Slot 6"))
            {

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

            


            }
        }
        else if (intrig == false && rb.velocity == Vector3.zero && grippress == false && hasmoved)
        {
            Debug.Log("Home");
            this.gameObject.transform.position = ogpos;
            hasmoved = false;
        }
    }
    private void OnTriggerEnter(Collider task1)

    {
        if (intrig == false)
        {
            //Debug.Log("Enter");
            task = task1;
            intrig = true;
            exiting = true;
        }
        else if (intrig == true)
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
            // Debug.Log("Exit");
            task = null;
            intrig = false;
            exiting = false;
        }
        else if (exiting == false)
        {
            exiting = true;
        }

    }
    
    public void HasMoved()
    {
        hasmoved = true;
    }
   
}
