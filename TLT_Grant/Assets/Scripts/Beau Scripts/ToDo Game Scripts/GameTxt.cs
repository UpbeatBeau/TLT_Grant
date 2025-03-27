using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTxt : MonoBehaviour
{
    //Vars
    private TextMeshPro walltxt;
    public int taskCount;
    private ExperienceManager em;

    private void Awake()
    {
        walltxt = this.gameObject.GetComponent<TextMeshPro>();
        em = ExperienceManager.instance.GetComponent<ExperienceManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(taskCount == 6)
        {
            walltxt.text = "Congratulations! You broke the project into smaller, more manageable tasks using a To Do list.";
            em.game2 = true;
            
        }
    }
}
