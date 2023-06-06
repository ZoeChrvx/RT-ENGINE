using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.IO;


public class SetVolume : MonoBehaviour
{
    public JsonReadWriteSystem jsonReadWriteSystem;
    public AudioMixer audioMixer;
    public Slider musicSlider;
    public Slider soundSlider;
    public float setVolume;

    public void Start()
    {
        if(File.Exists(Application.persistentDataPath + "/data.save"))
        {
            jsonReadWriteSystem.LoadFromJson();
        }
        audioMixer.GetFloat("music", out float musicValueForSlider);
        musicSlider.value = musicValueForSlider;

        audioMixer.GetFloat("sound", out float soundValueForSlider);
        musicSlider.value = soundValueForSlider;
    }
    public void MusicSlider(float volume)
    {
        audioMixer.SetFloat("music", volume);
        setVolume = volume;
    }
    
    public void SoundSlider(float volume)
    {
        audioMixer.SetFloat("sound", volume);
        setVolume = volume;
    }
}
