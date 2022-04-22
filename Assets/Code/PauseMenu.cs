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
    Toggle Toggle;
    public bool isMuted;

    public void Awake()
    {
        if (AudioListener.pause)
        {
            Toggle.isOn = true;
            isMuted = true;
        }
        else
        {
            Toggle.isOn = false;
            isMuted = false;
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
    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
    }
}
