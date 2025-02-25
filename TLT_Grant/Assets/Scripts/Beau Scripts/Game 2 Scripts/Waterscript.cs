using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterscript : MonoBehaviour
{
    public float destroyTime = 5f; // Time in seconds before the object is destroyed

    void Start()
    {
        Destroy(gameObject, destroyTime);

    }
}