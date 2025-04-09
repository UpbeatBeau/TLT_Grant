using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablettoface : MonoBehaviour
{
    //vars
    public float distanceFromCamera = .75f;

    private void Awake()
    {
        // Get the main camera
        Camera mainCamera = Camera.main;

        // Position the object in front of the camera
        Vector3 cameraForward = mainCamera.transform.forward;
        Vector3 newPosition = mainCamera.transform.position + cameraForward * distanceFromCamera;
        this.transform.position = newPosition;

        // Make the object face the camera
        this.transform.LookAt(mainCamera.transform.position);

        // Optionally, adjust the rotation so the object is not flipped
        this.transform.rotation = Quaternion.Euler(
            this.transform.rotation.eulerAngles.x,
            this.transform.rotation.eulerAngles.y + 180,
            this.transform.rotation.eulerAngles.z
        );

    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
