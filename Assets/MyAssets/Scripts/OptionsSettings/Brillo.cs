using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brillo : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] float sliderValue = 0.5f;
    [SerializeField] Image panel;
    private void Start()
    {
        sliderValue = 0.5f;
        slider.value = PlayerPrefs.GetFloat("brillo", sliderValue);
        panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, slider.value);
    }

    public void ChangeValue(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("brillo", sliderValue);
        panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, slider.value);
    }
}
