using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameButtons : MonoBehaviour
{
    public ReneTalks r;
    public CanvasGroup reneSuspense;
    public CanvasGroup reneChew1;
    public CanvasGroup reneChew2;
    public CanvasGroup textBox;
    public CanvasGroup wrongRene;
    public bool isWrongAnswer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (r.isItOkToMoveOn) {
            r.isItOkToMoveOn = false;
            isWrongAnswer = true;
            if (isWrongAnswer)
            {
                CanvasGroupDisplayer.Show(wrongRene);
                isWrongAnswer = false;
                StartCoroutine(moveImage(reneChew1, reneChew2));
            }
        }
    }

    public void answerQuestion()
    {
        CanvasGroupDisplayer.Hide(r.multipleChoiceBox);
        CanvasGroupDisplayer.Hide(r.reneClosedMouth);
        CanvasGroupDisplayer.Show(reneSuspense);
        StartCoroutine(r.eachLetterGeneral(".    .    .  ", .2f));
    }

    public void wrongAnswer()
    {
        answerQuestion();
        if (r.isItOkToMoveOn)
        {
            //r.isItOkToMoveOn = false;
            
        }
    }

    public void correctAnswer()
    {

    }

    public IEnumerator moveImage(CanvasGroup one, CanvasGroup two)
    {
        CanvasGroupDisplayer.Hide(textBox);
        int count = 0;
        while(count < 100)
        {
            count++;
            if (count % 2 == 0)
            {
                CanvasGroupDisplayer.Show(one);
                CanvasGroupDisplayer.Hide(two);
            }
            else
            {
                CanvasGroupDisplayer.Hide(one);
                CanvasGroupDisplayer.Show(two);
            }
            yield return new WaitForSeconds(0.25f);
        }
    }

}
