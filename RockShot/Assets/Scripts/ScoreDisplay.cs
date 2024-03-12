using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;
    public Timer timer;
    public int scoreCount;

    // Update is called once per frame
    void Update()
    {
        if (timer.timerTime <= 0)
        {
            finalScoreText.text = scoreText.text;
        }
        else
        {
            scoreText.text = scoreCount.ToString("00000000");
        }
    }
}
