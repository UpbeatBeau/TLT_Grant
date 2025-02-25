using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionControl : MonoBehaviour
{

    //Vars

    private OnClick clickControl;

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
        if (task.gameObject.CompareTag("Slot"))
        {
        
            Vector3 slotSpace = task.transform.position;
            
            this.gameObject.transform.position = slotSpace;

            clickControl.movable = false;

        
        }

    }
}
