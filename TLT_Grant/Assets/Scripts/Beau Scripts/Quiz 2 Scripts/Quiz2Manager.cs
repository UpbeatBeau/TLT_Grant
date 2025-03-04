using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quiz2Manager : MonoBehaviour
{
    //add the text and the scriptable objects
    public TextMeshProUGUI qtext;
    public Questions_SO current_question;
    public Questions_SO next_question;
    public GameObject[] buttons;
    public GameObject nextbutton;
    public GameObject input;


    private void Awake()
    {
        ExperienceManager.instance.GetComponent<ExperienceManager>().game2 = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        qtext.text = current_question.questiontxt;
        input.SetActive(false);
        nextbutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //write a function to update which question is showing
    public void Updatequiz()
    {
        if (current_question.lastquestion == false)
        {
            //change the text to the current question text
            qtext.text = next_question.questiontxt;
            current_question = next_question;
            next_question = current_question.nextquestion;

        }
        else {
            qtext.text = current_question.questiontxt;
            nextbutton.SetActive(true);
        }
        
        
    }
   public void ButtonOff()
    {
        foreach (GameObject btn in buttons)
        {
            btn.SetActive(false);
        }
        input.SetActive(true);

    }

    public void ClearInput()
    {
      
        input.GetComponent<TMP_InputField>().text = "";
    }
}
