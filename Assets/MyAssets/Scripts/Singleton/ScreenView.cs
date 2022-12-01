using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenView : MonoBehaviour
{
    [SerializeField] Toggle toogle;
    [SerializeField] Dropdown dropdown;
    Resolution[] myresolutions;
    void Start()
    {
        if (Screen.fullScreen)
        {
            toogle.isOn = true;
        }
        else
        {
            toogle.isOn = false;
        }
        CheckResolution();
    }

    private void CheckResolution()
    {
        myresolutions = Screen.resolutions;
        dropdown.ClearOptions();
        List<string> opciones = new List<string>();
        int currentR = 0;
        for (int i = 0; i < myresolutions.Length; i++)
        {
            string opcion = myresolutions[i].width + "x" + myresolutions[i].height;
            opciones.Add(opcion);
            if (Screen.fullScreen && myresolutions[i].width == Screen.currentResolution.width
                && myresolutions[i].height == Screen.currentResolution.height)
            {
                currentR = i;
            }
        }
        dropdown.AddOptions(opciones);
        dropdown.value = currentR;
        dropdown.RefreshShownValue();
        dropdown.value = PlayerPrefs.GetInt("indexR", 0);
    }

    public void ActivateScreen(bool myFullScreen)
    {
        Screen.fullScreen = myFullScreen;
    }

    public void ChangeResolution(int myindex)
    {
        PlayerPrefs.SetInt("indexR", dropdown.value);
        Resolution resolution = myresolutions[myindex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}