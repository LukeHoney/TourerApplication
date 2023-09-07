using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public bool soundEffects = false;

    public AudioSource finishAudio;
    public AudioSource clickedAudio;
    public AudioSource checkpointAudio;
    public AudioSource musicAudio;

    
    public void SoundEffectsOn()
    {
        soundEffects = true;
    }
    public void SoundEffectsOff()
    {
        soundEffects = false;
    }
    public void MusicOn()
    {
        musicAudio.Play();
    }
    public void MusicOff()
    {
        musicAudio.Stop();
    }
    public void FinishAudio()
    {
        if (soundEffects == true)
        {
            finishAudio.Play();
        }   
    }
    public void InformationClick()
    {
        if (soundEffects == true)
        {
            clickedAudio.Play();
        }
    }

    public void CheckpointAudio()
    {
        if (soundEffects == true)
        {
            checkpointAudio.Play();
        }
    }
}
