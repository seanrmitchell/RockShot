using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int scoreCount;

    // Update is called once per frame
    void Update()
    {
        text.text = scoreCount.ToString("00000000");
    }
}
