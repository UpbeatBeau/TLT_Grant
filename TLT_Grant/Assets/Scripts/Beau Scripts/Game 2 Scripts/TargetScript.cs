using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public GameObject triangle;
    public float distance;
    private Vector3 startpos;
    public GameScript gm;
    private bool gameover = false;

    public void Start()
    {
        startpos = triangle.transform.position;
        distance = startpos.x;
    }

    private void OnTriggerEnter(Collider collider)
    {
        distance += .01f;
    }

    public void Update()
    {
        triangle.transform.position = new Vector3(distance, startpos.y, startpos.z);
        if(distance >= 30f && gameover == false)
        {
            gm.YouWin();
            gameover = true;
        }
    }
}
