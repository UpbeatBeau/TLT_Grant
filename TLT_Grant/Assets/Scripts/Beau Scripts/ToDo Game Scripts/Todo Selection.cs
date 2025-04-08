using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;

public class TodoSelection : MonoBehaviour
{

    //Vars

    private bool intrig;
    private bool exiting;
    public InputActionReference leftinput;
    public InputActionReference rightinput;
    public TextMeshPro stickertxt;
    private Vector3 ogpos;
    private Quaternion ogrot;
    public Collider task;
    private TaskText tsktxt;
    private Rigidbody rb;
    public bool hasmoved;
    public bool selected;

    public bool grippress;

    private void Awake()
    {
        intrig = false;
        exiting = false;
        ogpos = this.gameObject.transform.position;
        ogrot = this.gameObject.transform.rotation;
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.isKinematic = true;
        hasmoved = false;
        selected = false;
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
        if(grippress == false && rb.velocity.y < 0 && selected)
        {
            hasmoved = true;
        }
        if ( intrig && rb.velocity == Vector3.zero && grippress == false && hasmoved)
        {
            //task.enabled = false;
            hasmoved = false;
            selected = false;

            if (task.gameObject.CompareTag("Slot 1") && tsktxt.full == false)
            {

                tsktxt.TaskFull();

                Vector3 slotSpace = task.transform.position;

                this.gameObject.transform.position = slotSpace;

                rb.isKinematic = true;

                rb.gameObject.GetComponent<XRGrabInteractable>().enabled = false;

            }
            else
            {
                CubeHome();
            }
            
        }
        else if (intrig == false && rb.velocity == Vector3.zero && grippress == false && hasmoved)
        {
            CubeHome();
        }
    }
    private void OnTriggerEnter(Collider task1)

    {
        if (intrig == false)
        {
            //Debug.Log("Enter");
            task = task1;
            tsktxt = task1.gameObject.GetComponentInParent<TaskText>();
            intrig = true;
            exiting = true;
        }
        else if (intrig == true)
        {
            //Debug.Log("Transition");
            intrig = false;
            task = null;
            task = task1;
            tsktxt = task1.gameObject.GetComponentInParent<TaskText>();
            intrig = true;
            exiting = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (exiting == true)
        {
            // Debug.Log("Exit");
            //other.GetComponentInParent<TaskText>().ClearTask();
            task = null;
            tsktxt = null;
            intrig = false;
            exiting = false;
        }
        else if (exiting == false)
        {
            exiting = true;
        }

    }
    
   public void SelectCube()
    {
        selected = true;
        rb.isKinematic = false;
    }

    private void CubeHome()
    {
        this.gameObject.transform.position = ogpos;
        this.gameObject.transform.rotation = ogrot;
        rb.isKinematic = true;
        hasmoved = false;
        selected = false;
    }
   
}
