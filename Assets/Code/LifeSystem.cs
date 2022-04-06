using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeSystem : MonoBehaviour
{
    public GameObject [] lives;
    public static int life = 3;
 
    void Update()
    {
        if (life == 0)
        {
            GameOver();
            life = 3;
            TotalScore.totalScore = ScoreCounter.scoreValue;
            ScoreCounter.scoreValue = 0;
        }
        if (life < 1)
        {
            Destroy(lives[0].gameObject);
        }
        else if (life < 2)
        {
            Destroy(lives[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(lives[2].gameObject);
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
