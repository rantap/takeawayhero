using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{
    [SerializeField] 
    GameObject instructionMenu;
    [SerializeField]
    GameObject [] pages; 
    [SerializeField] 
    GameObject backButton;
    [SerializeField] 
    GameObject forwardButton;
    int i = 0;

    public void Update()
    {
        if (i == 0)
        {
            backButton.SetActive(false);
        }
        if (i == 1)
        {   
            backButton.SetActive(true);
        }
        if (i == pages.Length - 1)
        {
            forwardButton.SetActive(false);
        }
        if (i == pages.Length - 2)
        { 
            forwardButton.SetActive(true);
        }
    }
    public void Forward()
    {
        if (i + 1 < pages.Length)
        {
            i++;
            pages[i-1].SetActive(false);
            pages[i].SetActive(true);
        }

    }
    public void Back()
    {
        if (i - 1 >= 0)
        {
            i--;
            pages[i+1].SetActive(false);
            pages[i].SetActive(true);
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
}
