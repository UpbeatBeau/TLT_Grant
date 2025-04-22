using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static GameObject instance;
    public GameObject offsetactive;
    public GameObject offsetinactive;

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
