using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Windows.Speech;
//using System.Collections.Generic;
using System.Linq;
using System;

public class Recognition : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, Action> keywordActions = new Dictionary<string, Action>();


    void Start()
    {
        if(PhraseRecognitionSystem.isSupported)
        {
            Debug.Log("Windows Speech Recognition is supported");
        }
        else
        {
            Debug.Log("Windows Speech Recognition is NOT supported");
        }

        keywordActions.Add("jump", Jump);
       
        keywordRecognizer = new KeywordRecognizer(keywordActions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizerOnPhraseRecognized;
        keywordRecognizer.Start();

    }

    void KeywordRecognizerOnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("Keyword: " + args.text);
        keywordActions[args.text].Invoke();
    }

    void Jump()
    {
        Debug.Log("you just said jump!");

    }


}
