using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    GameObject pauseMenu;
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
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        LifeSystem.life = 3;
        TotalScore.totalScore = ScoreCounter.scoreValue;
        ScoreCounter.scoreValue = 0;
        MoveObject.objectSpeed = 0.2f;
    }
    public void QuitGame()
    {
        SceneManager.LoadScene(3);
        LifeSystem.life = 3;
        TotalScore.totalScore = ScoreCounter.scoreValue;
        ScoreCounter.scoreValue = 0;
        MoveObject.objectSpeed = 0.2f;
    }
}