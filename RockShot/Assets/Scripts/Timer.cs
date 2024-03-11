using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public float timerTime;

    // Update is called once per frame
    void Update()
    {
        timerTime -= Time.deltaTime;
        timeText.text = timerTime.ToString("00.00");
    }
}
