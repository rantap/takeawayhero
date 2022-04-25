using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    [SerializeField]
    Toggle musicToggle;
    [SerializeField]
    Toggle soundToggle;
    public static bool musicOn = true;
    public static bool soundOn = true;

    public void Awake()
    {
        if (musicToggle.isOn)
        {
            audioMixer.SetFloat("musicVolume", -80f);
            musicOn = false;
        }
        else 
        {
            audioMixer.SetFloat("musicVolume", 0f);
            musicOn = true;
        }
        if (soundToggle.isOn)
        {
            audioMixer.SetFloat("sfxVolume", -80f);
            soundOn = false;
        }
        else
        {
            audioMixer.SetFloat("sfxVolume", 0f);
            soundOn = true;
        }
    }
    public void ToggleMusic()
    {
        if (musicOn == true)
        {
            audioMixer.SetFloat("musicVolume", -80f);
            musicOn = false;
        }
        else if (musicOn == false)
        {
            audioMixer.SetFloat("musicVolume", 0f);
            musicOn = true;
        }
    }
    public void ToggleSFX()
    {
        if (soundOn == true)
        {
            audioMixer.SetFloat("sfxVolume", -80f);
            soundOn = false;
        }
        else if (soundOn == false)
        {
            audioMixer.SetFloat("sfxVolume", 0f);
            soundOn = true;
        }
    }
}
