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
        
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startpos;
        //transform.rotation = startrot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
