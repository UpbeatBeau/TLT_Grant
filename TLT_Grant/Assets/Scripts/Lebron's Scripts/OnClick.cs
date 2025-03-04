using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{

    //Vars

    Vector3 clickPosition;
    public Vector3 offset;
    public bool movable = true;
     

    //Awake  is called on spawn of this script before start
    private void Awake()
    {
        offset = transform.position;
    }

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(gameObject.transform.position);
       


    }

    private void OnMouseDown()

    {

        clickPosition = GetMousePos();

    }

    private void OnMouseDrag()
    {
        if (true)
        {
            Vector3 objpos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, clickPosition.z);
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(objpos);

        }
        else
        {
            //Ding the nothing

        }
        

    }

    /*private void OnMouseDown()
    {

            clickPosition = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = offset - Camera.main.WorldToScreenPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, clickPosition.z));

        
            
        
    }

    void OnMouseDrag()
    {
        
            Vector3 onScreenClickPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, clickPosition.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(onScreenClickPos) + offset;

            transform.position = curPosition;
        
    }*/
}
