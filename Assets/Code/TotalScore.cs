using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TotalScore : MonoBehaviour
{ 
    public static int totalScore = 0;
    public TextMeshProUGUI totalScoreGUI;
    void Start()
    {
        totalScoreGUI = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        totalScoreGUI.text = totalScore.ToString();
    }
}
