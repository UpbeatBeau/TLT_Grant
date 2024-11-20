using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;


public class VoiceRecognition : MonoBehaviour
{

    //Variables 
    private Text SpeechText;

    protected DictationRecognizer Recognizer;

    // Start is called before the first frame update
    void Start()
    {
        //StartVoiceRecognition();
    }

    
    private void Recognizer_OnDictationComplete(DictationCompletionCause completioncause)
    {
        if (completioncause != DictationCompletionCause.Complete)
        {
            Debug.LogWarningFormat("Dictation Error : {0}", completioncause);

            /*switch(completioncause)
            {

            }*/
        }
    }
}
