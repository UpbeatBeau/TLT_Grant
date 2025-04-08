using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class StartPlayer : MonoBehaviour
{
    //vars
    public Vector3 startpos;
    public Quaternion startrot;


    private void Awake()
    { 
        transform.position = startpos;
        transform.rotation = startrot;
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
