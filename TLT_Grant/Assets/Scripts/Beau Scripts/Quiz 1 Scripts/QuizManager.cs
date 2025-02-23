using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuizManager : MonoBehaviour
{
    //add the text and the scriptable objects
    public TextMeshProUGUI qtext;
    public Questions_SO current_question;
    
    // Start is called before the first frame update
    void Start()
    {
        Updatequiz();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //write a function to update which question is showing
    public void Updatequiz()
    {
        //change the text to the current question text
        qtext.text = current_question.questiontxt;
        //queue the next question
        current_question = current_question.nextquestion;
    }
}
