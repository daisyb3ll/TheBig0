using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFunction : MonoBehaviour
{
    public StoryPanels s;
    public CanvasGroup mainGamePanel;
    public CanvasGroup mainScenePanel;
    public AudioSource gameMusic;
    public AudioSource scenesMusic;
    public bool isItOkToStartGameMusic = true;
    public int lives = 4;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (s.isItOkToStartGame)
        {
            s.hideAll();
            CanvasGroupDisplayer.Hide(mainScenePanel);
            CanvasGroupDisplayer.Show(mainGamePanel);
            if(isItOkToStartGameMusic)
            {
                isItOkToStartGameMusic = false;
                gameMusic.Play();
            }
         }
    }
}