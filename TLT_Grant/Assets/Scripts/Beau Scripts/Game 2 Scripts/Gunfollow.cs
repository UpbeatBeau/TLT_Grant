using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfollow : MonoBehaviour
{
    
    public float sensitivity = 10f; // Speed of rotation
    public Vector2 xRotationBoundaries = new Vector2(-45f, 45f); // X-axis rotation boundaries (pitch)
    public Vector2 yRotationBoundaries = new Vector2(-90f, 90f); // Y-axis rotation boundaries (yaw)
    private float rotationX = 0f;
    private float rotationY = 0f;

  
    void Start()
    {
        
    }

    void Update()
    {
        // Get the mouse movement
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Calculate the rotation
        rotationY += mouseX;
        rotationX -= mouseY;

        // Apply the boundaries to the rotation angles
        rotationX = Mathf.Clamp(rotationX, xRotationBoundaries.x, xRotationBoundaries.y);
        rotationY = Mathf.Clamp(rotationY, yRotationBoundaries.x, yRotationBoundaries.y);

        // Apply the rotation to the object
        transform.localRotation = Quaternion.Euler(rotationX,rotationY,0f);
        
    }
}