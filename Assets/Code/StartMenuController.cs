using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    // Start is called before the first frame update

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
