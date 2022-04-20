using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighscorePrint : MonoBehaviour
{
    [SerializeField] 
    GameObject highscoreMenu;
    public int highScore_1 = 0;
    public int highScore_2 = 0;
    public int highScore_3 = 0;
    [SerializeField] 
    public TextMeshProUGUI highScoreGUI1;
    [SerializeField] 
    public TextMeshProUGUI highScoreGUI2;
    [SerializeField] 
    public TextMeshProUGUI highScoreGUI3;
    
    // Start is called before the first frame update
    //void Start()
    //{
    //    highScore_1 = PlayerPrefs.GetInt("highScore_1", 0);
    //    highScore_2 = PlayerPrefs.GetInt("highScore_2", 0);
    //    highScore_3 = PlayerPrefs.GetInt("highScore_3", 0);
    //    //highScoreGUI = GetComponent<TextMeshProUGUI>();
    //}    
//
    //// Update is called once per frame
    //void Update()
    //{
    //    
    //    //highScoreGUI.text = "test";
//
    //}
        
    public void LoadHighscore()
    {
        highscoreMenu.SetActive(true);
        Time.timeScale = 0f;
        highScoreGUI1.text = "1. " + PlayerPrefs.GetInt("highScore_1", 0).ToString();
        highScoreGUI2.text = "2. " + PlayerPrefs.GetInt("highScore_2", 0).ToString();
        highScoreGUI3.text = "3. " + PlayerPrefs.GetInt("highScore_3", 0).ToString();
        
        
    }
    public void Resume() 
    {
        highscoreMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
