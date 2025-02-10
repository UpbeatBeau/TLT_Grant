using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{

    //Vars

    Vector3 clickPosition;
    private Vector3 offset;


    //Awake  is called on spawn of this script before start
    private void Awake()
    {

    }

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(gameObject.transform.position);

    }

    private void OnMouseDown()

    {
       
        clickPosition = Input.mousePosition - GetMousePos();

    }

    private void OnMouseDrag()
    {
        gameObject.transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition -  clickPosition);
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
