using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumenScript : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] float sliderValue = 0.5f;
    [SerializeField] Image imageMute;
    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", sliderValue);
        AudioListener.volume = slider.value;
        isMute();
    }
    public void isMute()
    {
        if (sliderValue == 0)
        {
            imageMute.enabled = true;
        }
        else
        {
            imageMute.enabled = false;
        }
    }
    public void ChangeValue(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = slider.value;
        isMute();
    }
}
