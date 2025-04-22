using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tablettoface : MonoBehaviour
{
    //vars
    public static GameObject instance;

    public GameObject offsetactive;
    public GameObject offsetinactive;
    public bool active;
    public float speed;
    public Material activemat;
    public Material inactivemat;
    private MeshRenderer mesh;
    public MenuController menu;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this.gameObject;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        mesh = GetComponent<MeshRenderer>();
        menu = GetComponentInChildren<MenuController>();
       

    }
    // Start is called before the first frame update
    void Start()
    {
        offsetactive = Player.instance.GetComponent<Player>().offsetactive;
        offsetinactive = Player.instance.GetComponent<Player>().offsetinactive;
        transform.position = offsetactive.transform.position;
        active = true;
        
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

    public void Center(string s)
    {
        transform.position = offsetactive.transform.position;
        active = true;
        menu.page = 0;
        menu.room = s;
    }
}
