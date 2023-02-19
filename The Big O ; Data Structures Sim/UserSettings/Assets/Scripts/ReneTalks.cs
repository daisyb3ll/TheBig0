using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReneTalks : MonoBehaviour
{
    public StoryPanels s;
    public Text dialogue;
    public bool isItOkToStartTimer = true;
    public bool okToStartText = true;
    public bool isItOkToMoveOn = false;
    public CanvasGroup reneClosedMouth;
    public CanvasGroup reneOpenMouth;
    public CanvasGroup multipleChoiceBox;
    public string[] dialogueArray = {"Ok, guys. Suprise Quiz! You over there. What's the definition of Big O?"};
    public int pos = 0;
    public float secondCount;


    void Start()
    {
        CanvasGroupDisplayer.Hide(multipleChoiceBox);
    }

    void Update()
    {
        if(s.isItOkToStartGame && okToStartText)
        {
            okToStartText = false;
            StartCoroutine(eachLetter("Ok, guys. Suprise Quiz! You over there. What's the definition of Big O?", 0.05f));
        }
    }


    public IEnumerator eachLetter(string s, float seconds)
    {
        dialogue.text = "";
        int count = 0;
        foreach(char c in s)
        {
            count++;
            if(count % 3 == 0)
            {
                CanvasGroupDisplayer.Show(reneClosedMouth);
                CanvasGroupDisplayer.Hide(reneOpenMouth);
            } else if (count% 2 == 0)
            {
                CanvasGroupDisplayer.Hide(reneClosedMouth);
                CanvasGroupDisplayer.Show(reneOpenMouth);
            }
            yield return new WaitForSeconds(seconds);
            dialogue.text += c;
            if(c.ToString() == s.Substring(s.Length - 1))
            {
                CanvasGroupDisplayer.Show(reneClosedMouth);
                CanvasGroupDisplayer.Hide(reneOpenMouth);
                CanvasGroupDisplayer.Show(multipleChoiceBox);
            }
        }
    }
    public IEnumerator eachLetterGeneral(string s, float seconds)
    {
        dialogue.text = "";
        foreach (char c in s)
        {
            secondCount++;
            yield return new WaitForSeconds(seconds);
            dialogue.text += c;
        }
        if(secondCount > seconds)
        {
            secondCount = 0;
            isItOkToMoveOn = true;
        }
    }
}
