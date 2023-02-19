using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class StartButton : MonoBehaviour
{
    public AudioSource buttonClick;
    public AudioSource backgroundMusic;
    public AudioSource mainGameMusic;
    public CanvasGroup StartScreen;
    public CanvasGroup PlayScreen;
    public bool isItOkToStartScenes = false;

    public void onPress()
    {
        buttonClick.Play();
        CanvasGroupDisplayer.Hide(StartScreen);
        CanvasGroupDisplayer.Show(PlayScreen);
        AudioControl.Mute(backgroundMusic);
        mainGameMusic.Play();
        isItOkToStartScenes = true;
}
}
