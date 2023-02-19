using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPanels : MonoBehaviour
{

    public StartButton s;
    public GameFunction g;
    public CanvasGroup sceneOne;
    public CanvasGroup sceneTwo;
    public CanvasGroup sceneThree;
    public CanvasGroup sceneFour;
    public AudioSource gameMusic;
    public AudioSource doorShut;
    public AudioSource crowd;
    public AudioSource heaven;
    public bool isItOkToStartTimer = true;
    public int panelNumber = 0;
    public bool isItOkToStartGame = false;
    public bool okToFadeOut = true;

    void Update()
    {
        storyAction();
        if(isItOkToStartTimer && s.isItOkToStartScenes)
        {
            isItOkToStartTimer = false;
            StartCoroutine(CountdownUntilNextScene());
        }
    }

    public void storyAction()
    {
        if (panelNumber == 0)
        {
            //crowd.Play();
            hideAll();
            CanvasGroupDisplayer.Show(sceneOne);
        }
        if (panelNumber == 1)
        {
            //doorShut.Play();
        }
        else if (panelNumber == 2)
        {
            hideAll();
            CanvasGroupDisplayer.Show(sceneTwo);
        }
        else if (panelNumber == 3)
        {
            heaven.Play();
            hideAll();
            CanvasGroupDisplayer.Show(sceneThree);
        }
        else if (panelNumber == 4)
        {
            
            if (okToFadeOut)
            {
                okToFadeOut = false;
                StartCoroutine(AudioFadeOut.FadeOut(s.mainGameMusic, 3f));
            }
            hideAll();
            CanvasGroupDisplayer.Show(sceneFour);
        } else if (panelNumber > 4)
        {
            isItOkToStartGame = true;
        }
    }

    public void hideAll()
    {
        CanvasGroupDisplayer.Hide(sceneOne);
        CanvasGroupDisplayer.Hide(sceneTwo);
        CanvasGroupDisplayer.Hide(sceneThree);
        CanvasGroupDisplayer.Hide(sceneFour);
    }

    IEnumerator CountdownUntilNextScene()
    {
        yield return new WaitForSeconds(3f);
        panelNumber++;
        isItOkToStartTimer = true;
    }


}
