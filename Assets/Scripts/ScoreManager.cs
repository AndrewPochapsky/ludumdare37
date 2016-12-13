using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {
    public static int score;
    public Text scoreText, highScoreText;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = "Current Score: " + score;
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highscore", 0);
    }

    public static void StoreHighScore()
    {
        if(score > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

}
