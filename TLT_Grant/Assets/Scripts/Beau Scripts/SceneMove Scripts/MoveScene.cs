using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public string nxtscene;
    private ExperienceManager em;
    private Canvas entergame;
    private bool intrig;

    private void Awake()
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {
        em = ExperienceManager.instance.GetComponent<ExperienceManager>();
        entergame = ExperienceManager.instance.GetComponentInChildren<Canvas>();
        entergame.enabled = false;
        intrig = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            NextScene(nxtscene);
            em.game1 = true;
        }
        if (intrig)
        {
            entergame.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                NextScene(nxtscene);
            }
        }
        
        
    }


    public void OnTriggerEnter(Collider other)
    {
        intrig = true;
        
    }

    private void OnTriggerExit(Collider other)
    {
        intrig = false;
        entergame.enabled = false;
    }


    //move to the next scene when called
    public void NextScene(string nxt)
    {
        SceneManager.LoadScene(nxt);
    }

   
}
