using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class MoveScene : MonoBehaviour
{
    public string nxtscene;
    private ExperienceManager em;
    public TextMeshPro entergame;
    public bool intrig;
    public InputActionReference rtrigger;
    private bool triggerpress;

    private void Awake()
    {
        entergame.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        em = ExperienceManager.instance.GetComponent<ExperienceManager>();
        
        intrig = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (rtrigger.action.ReadValue<float>() != 0f)
        {
            triggerpress = true;
        }
        else
        {
            triggerpress = false;
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            NextScene(nxtscene);
            em.game1 = true;
        }


        if (intrig)
        {
            entergame.enabled = true;
            if (triggerpress)
            {
                NextScene(nxtscene);
                em.game1 = true;
            }
        }
        
        
    }


    public void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            Debug.Log("enter");
            intrig = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        if (other.CompareTag("Player"))
        {
            intrig = false;
            entergame.enabled = false;
        }
       
    }


    //move to the next scene when called
    public void NextScene(string nxt)
    {
        SceneManager.LoadScene(nxt);
    }

   
}
