using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    [SerializeField]
    Toggle Toggle;
    public void Awake()
    {
        if (AudioListener.pause)
        {
            Toggle.isOn = true;
        }
        else
        {
            Toggle.isOn = false;
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
