using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioControl
{
    public static void Mute(AudioSource audio)
    {
        audio.volume = 0;
    }

    public static void Unmute(AudioSource audio)
    {
        audio.volume = 1;
    }
}
