using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI highScoreText;
    public Timer timer;
    public int scoreCount;

    // Update is called once per frame
    void Update()
    {
        if (timer.timerTime <= 0)
        {
            finalScoreText.text = scoreText.text;

            if (PlayerPrefs.GetInt("Highscore") > scoreCount)
            {
                highScoreText.text = PlayerPrefs.GetInt("Highscore").ToString("00000000");
            }
            else
            {
                PlayerPrefs.SetInt("Highscore", scoreCount);
                highScoreText.text = scoreCount.ToString("00000000");
                highScoreText.color = Color.red;
            }
        }
        else
        {
            scoreText.text = scoreCount.ToString("00000000");
        }
    }
}
