using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionEvent : MonoBehaviour
{
    [SerializeField] 
    GameObject instructionMenu;
    [SerializeField] 
    GameObject skipButton;

    public void OpenInstructions()
    {
        instructionMenu.SetActive(true);
        skipButton.SetActive(false);
    }
}