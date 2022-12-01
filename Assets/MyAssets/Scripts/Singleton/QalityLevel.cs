using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QalityLevel : MonoBehaviour
{
    [SerializeField] Dropdown dropdown;
    [SerializeField] int myQuality;
    void Start()
    {
        myQuality = PlayerPrefs.GetInt("indexQuality", 3);
        dropdown.value = myQuality;
        MyQuality();
    }
    public void MyQuality()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("indexQuality", dropdown.value);
        myQuality = dropdown.value;
    }
}
