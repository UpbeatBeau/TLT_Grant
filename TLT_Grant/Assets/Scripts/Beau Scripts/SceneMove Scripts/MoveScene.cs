using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public string nxtscene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            NextScene(nxtscene);
        }
    }
   

    //move to the next scene when called
    public void NextScene(string nxt)
    {
        SceneManager.LoadScene(nxt);
    }
}
