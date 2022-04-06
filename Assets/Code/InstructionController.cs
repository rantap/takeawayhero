using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionController : MonoBehaviour
{     
    [SerializeField]
    GameObject [] pages; 
    int i = 0;

    public void Exit()
    {
        SceneManager.LoadScene(0);
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
}
