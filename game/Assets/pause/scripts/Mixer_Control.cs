using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Mixer_Control : MonoBehaviour {

    public AudioMixer mixerMusic;
    public Slider sliderMusic;

    public AudioMixer mixerSFX;
    public Slider sliderSFX;

    float musicData;
    float sfxData;

    //funcao que recebe um float, ela vai controlar o mixer

    public void MusicVolume(float vol)
    {
        mixerMusic.SetFloat("MusicVolume", vol);
        PlayerPrefs.SetFloat("MusicVolume", vol);
    }

    public void SFXVolume(float vol)
    {
        mixerSFX.SetFloat("SFXVolume", vol);
        PlayerPrefs.SetFloat("SFXVolume", vol);
    }

    // Use this for initialization
    void Start()
    {
        sliderMusic.value = PlayerPrefs.GetFloat("MusicVolume");
        sliderSFX.value = PlayerPrefs.GetFloat("SFXVolume");
    }

    public void gravarVolume() {
        musicData = PlayerPrefs.GetFloat("SFXVolume");
        sfxData = PlayerPrefs.GetFloat("MusicVolume");
    }

    public void cancelarAlteracao()
    {
        sliderMusic.value = musicData;
        sliderSFX.value = sfxData;
    }
}
