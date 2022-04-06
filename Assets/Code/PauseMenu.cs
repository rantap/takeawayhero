using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    GameObject pauseMenu;

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
    }
    public void QuitGame()
    {
        SceneManager.LoadScene(2);
        LifeSystem.life = 3;
        TotalScore.totalScore = ScoreCounter.scoreValue;
        ScoreCounter.scoreValue = 0;
    }
}
