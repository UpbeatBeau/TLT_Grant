using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class BookSelection : MonoBehaviour
{
    //Vars

    public Collider task;
    private bool intrig;
    public InputActionReference leftinput;
    public InputActionReference rightinput;
    private Vector3 ogpos;
    private Quaternion ogrot;
    private RaycastHit hit;
    public float offsety;
    private BookSpots lasthit;

    public bool grippress;



    // Awake is called on spawn

    private void Awake()
    {
        intrig = false;
        ogpos = this.gameObject.transform.position;
        ogrot = this.gameObject.transform.rotation;

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

                this.gameObject.transform.position = slotSpace + new Vector3(0f,offsety,0f);

                this.gameObject.transform.rotation = ogrot;

        }
        else if (grippress == false && intrig == false)
        {
            //this.gameObject.transform.position = ogpos;
            //this.gameObject.transform.rotation = ogrot;
        }

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, 1000f, Physics.DefaultRaycastLayers, QueryTriggerInteraction.Collide) && hit.collider.CompareTag("Sticky") == false)
        {
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.yellow);
            //Debug.Log("Did Hit");
            task = hit.collider;
            intrig = true;
            if (lasthit == null)
            {   
                lasthit = task.gameObject.GetComponent<BookSpots>();
                lasthit.on = true;
                
            }
            else
            {
                lasthit.on = false;
                lasthit = null;
            }
        }
        else
        {
            lasthit.on = false;
            lasthit = null;
            intrig = false;
            
        }
        //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.yellow);
    }
}
