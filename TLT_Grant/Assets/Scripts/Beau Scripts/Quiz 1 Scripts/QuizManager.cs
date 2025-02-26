using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    //add the text and the scriptable objects
    public TextMeshProUGUI qtext;
    public Questions_SO current_question;
    public Questions_SO next_question;
    public int oddsum;
    public int evensum;
    public int num;
    public TextMeshProUGUI qendtxt;
    public GameObject[] buttons;
    public GameObject nextbutton;
    
    // Start is called before the first frame update
    void Start()
    {
        qtext.text = current_question.questiontxt;
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
            //add the number to the appropriate sum
            if (current_question.isodd == true)
            {
                oddsum += num;
            }
            else
            {
                evensum += num;
            }
            current_question = next_question;
            next_question = current_question.nextquestion;

        }
        else {
            qtext.text = current_question.questiontxt;

            if (current_question.isodd == true)
            {
                oddsum += num;
            }
            else
            {
                evensum += num;
            }
            QuizEnd();
        }
        
    }
   public void QuizEnd()
    {
        int score;
        score = oddsum - evensum;
        qtext.text = "Your Score is " + score;
        qendtxt.enabled = true;
        foreach (GameObject btn in buttons)
        {
            btn.SetActive(false);
        }
        nextbutton.SetActive(true);
        nextbutton.GetComponent<Image>().enabled = true;
    }
}
