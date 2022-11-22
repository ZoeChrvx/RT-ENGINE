using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public AudioSource musiqueSource;
    public Slider volumeSlider;
    public TextMeshProUGUI txtVolume;


    public void SliderChange()
    {
        musiqueSource.volume = volumeSlider.value;
        txtVolume.text = "Volume : " + (musiqueSource.volume * 100).ToString("00") + "%"; //Marquer les 2 "00" bloque les floats a des nombres a deux chiffres MAX
    }
}
