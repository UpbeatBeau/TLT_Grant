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
        Recognizer = new DictationRecognizer();

        Recognizer.DictationResult += (text, confidence) =>
        {
            Debug.LogFormat("Dictation result: {0}", text);
            SpeechText.text += text + "\n";
        };

        Recognizer.DictationComplete += (completionCause) =>
        {
            if (completionCause != DictationCompletionCause.Complete)
                Debug.LogErrorFormat("Dictation error: {0}.", completionCause);
        };

        Recognizer.DictationError += (error, hresult) =>
        {
            Debug.LogErrorFormat("Dictation error: {0}; HResult = {1}.", error, hresult);
        };

        Recognizer.Start();
    }
}
