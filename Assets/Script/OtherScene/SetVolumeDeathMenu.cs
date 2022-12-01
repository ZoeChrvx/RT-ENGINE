using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolumeDeathMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void MusicSlider(float volume)
    {
        audioMixer.SetFloat("music", volume);
    }
    
    public void SoundSlider(float volume)
    {
        audioMixer.SetFloat("sound", volume);
    }
}
