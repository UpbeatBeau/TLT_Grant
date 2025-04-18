using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : MonoBehaviour
{
    public static GameObject instance;
    public bool game1 = false;
    public bool game2 = false;
    public bool game3 = false;
    public bool game4 = false;
    public int gamecomp = 0;
    public GameObject ball;

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
        
       ball.SetActive(false);
    }

    private void Update()
    {
        if (gamecomp == 4)
        {
            ball.SetActive(true);
        }
    }

}
