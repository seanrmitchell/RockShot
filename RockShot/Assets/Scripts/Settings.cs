using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI senseText;

    [SerializeField]
    private GameObject mainPanel, settingsPanel;

    private void Update()
    {
        senseText.text = slider.value.ToString();
    }

    public void SensitivityChange()
    {
        PlayerPrefs.SetFloat("Sensitivity", slider.value);
        Debug.Log(PlayerPrefs.GetFloat("Sensitivity"));
        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }
}
