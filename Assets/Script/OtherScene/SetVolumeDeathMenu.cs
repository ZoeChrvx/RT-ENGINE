using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolumeDeathMenu : MonoBehaviour
{
    public JsonReadWriteSystem jsonReadWriteSystem;
    public AudioMixer audioMixer;
    public void MusicSlider(float volume)
    {
        jsonReadWriteSystem.SaveToJson();
        audioMixer.SetFloat("music", volume);
    }
    
    public void SoundSlider(float volume)
    {
        jsonReadWriteSystem.SaveToJson();
        audioMixer.SetFloat("sound", volume);
    }
}
