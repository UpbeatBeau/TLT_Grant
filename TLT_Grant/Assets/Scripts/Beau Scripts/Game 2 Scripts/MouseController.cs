using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController: MonoBehaviour
{
    public float sensitivity = 10f; // Adjust this value to control the sensitivity of the rotation

    private float rotationX = 0f;
    private float rotationY = 0f;
   

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        // Get the mouse movement
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Calculate the rotation
        rotationY += mouseX;
        rotationX -= mouseY;

        // Clamp the vertical rotation to avoid flipping the camera
        rotationX = Mathf.Clamp(rotationX, -20f, 5f);
        rotationY = Mathf.Clamp(rotationY, -30f, 30f);

        // Apply the rotation to the camera
         transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);
       
    }
}
