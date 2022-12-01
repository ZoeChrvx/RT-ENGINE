using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SetVolume : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider musicSlider;
    public Slider soundSlider;

    public void Start()
    {
        audioMixer.GetFloat("music", out float musicValueForSlider);
        musicSlider.value = musicValueForSlider;

        audioMixer.GetFloat("sound", out float soundValueForSlider);
        musicSlider.value = soundValueForSlider;
    }
    public void MusicSlider(float volume)
    {
        audioMixer.SetFloat("music", volume);
    }
    
    public void SoundSlider(float volume)
    {
        audioMixer.SetFloat("sound", volume);
    }
}
