using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFace : MonoBehaviour
{

    private Camera mainCamera;

    void Start()
    {
        // Get the main camera
        mainCamera = Camera.main;
    }

    void LateUpdate()
    {
        // Ensure the TextMeshPro object faces the camera
        if (mainCamera != null)
        {
            transform.LookAt(mainCamera.transform);
            transform.rotation = Quaternion.LookRotation(mainCamera.transform.forward);
        }
    }
}

