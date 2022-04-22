using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    Toggle Toggle;
    public bool isMuted;

    void Start()
    {
        if (!Toggle.isOn)
        {
            isMuted = false;    
        }
        else 
        {
            isMuted = true;
        }
    }

    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
    }
}
