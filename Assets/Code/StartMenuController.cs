using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    [SerializeField]
    Toggle musicToggle;
    [SerializeField]
    Toggle soundToggle;
    public void Awake()
    {
        if (!AudioManager.musicOn)
        {
            musicToggle.isOn = true;
        }
        else 
        {
            musicToggle.isOn = false;
        }
        if (!AudioManager.soundOn)
        {
            soundToggle.isOn = true;
        }
        else 
        {
            soundToggle.isOn = false;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void LoadInstructions()
    {
        SceneManager.LoadScene(4);
    }
    public void QuitGame()
    {
        print("Quit Game!");
        Application.Quit();
    }
}
