using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HighscoreSystem : MonoBehaviour
{
    public int tempScore = 0;
    public int newScore = 0;
    public int highScore_1 = 0;
    public int highScore_2 = 0;
    public int highScore_3 = 0;
    

    void Start()
    {
        newScore = TotalScore.totalScore;
        tempScore = 0;
        highScore_1 = PlayerPrefs.GetInt("highScore_1", 0);
        highScore_2 = PlayerPrefs.GetInt("highScore_2", 0);
        highScore_3 = PlayerPrefs.GetInt("highScore_3", 0);
        
    }
    void Update()
    {
        SetHighscore();
    }
    public void SetHighscore()
    {
        if(newScore >= highScore_1)
        {
            tempScore = highScore_2;
            highScore_3 = tempScore;
            highScore_2 = highScore_1;
            highScore_1 = newScore;
            newScore = 0;
        }else if(newScore < highScore_1 && newScore >= highScore_2)
        {
            highScore_3 = highScore_2;
            highScore_2 = newScore;
            newScore = 0;
        }else if(newScore < highScore_2 && newScore > highScore_3)
        {
            highScore_3 = newScore;
            newScore = 0;
        }
        PlayerPrefs.SetInt("highScore_1", highScore_1);
        PlayerPrefs.SetInt("highScore_2", highScore_2);
        PlayerPrefs.SetInt("highScore_3", highScore_3);
        
    }
}
