using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tablettoface : MonoBehaviour
{
    //vars
    
    public GameObject offsetactive;
    public GameObject offsetinactive;
    public bool active;
    public float speed;
    public Material activemat;
    public Material inactivemat;
    private MeshRenderer mesh;

    private void Awake()
    {
       transform.position = offsetactive.transform.position;
        active = true;
        mesh = GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        if (active)
        {
            mesh.material = activemat;
            transform.position = Vector3.MoveTowards(transform.position, offsetactive.transform.position, step);
        }
        else
        {
            mesh.material = inactivemat;
            transform.position = Vector3.MoveTowards(transform.position,offsetinactive.transform.position, step);
        }
    }
}
