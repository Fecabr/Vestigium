using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public AudioManager audio;


    public void PlayAudio(int index)
    {
        audio.ReproducirSonido(index, 1, 1);
    }
    public void StopAudio(int index)
    {
        audio.DetenerSonido(index);
    }
}
