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
    public GameObject gameOver;

    private void Awake()
    {
        Time.timeScale = 1f;
        gameOver.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (timerTime <= 0 )
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            timerTime -= Time.deltaTime;
            timeText.text = timerTime.ToString("00.00");
        }
    }
}
