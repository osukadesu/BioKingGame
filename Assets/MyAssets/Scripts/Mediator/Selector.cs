using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour
{

    [SerializeField]
    private Text txtInfo;
    public bool isman, iswoman;
    public Toggle checkMan;
    public Toggle checkWoman;

    [SerializeField]
    private Button _btnSave;

    [SerializeField]
    private float tiempo = 0f;
    private void Update()
    {
        tiempo = tiempo - 1 * Time.deltaTime;
        Checked();
    }
    public void Checked()
    {
        if (checkMan.isOn == false && checkWoman.isOn == false)
        {
            txtInfo.text = "Selecciona un genero";
            AllFalse();
        }
        else
        {
            if (checkMan.isOn == true && checkWoman.isOn == true)
            {
                txtInfo.text = "Solo un genero";
                AllFalse();
            }
            else
            {
                if (checkMan.isOn && checkWoman.isOn == false)
                {
                    isman = true;
                    AllTrue();
                }
                if (checkWoman.isOn && checkMan.isOn == false)
                {
                    iswoman = true;
                    AllTrue();
                }
            }
        }
    }
    public void AllFalse()
    {
        _btnSave.enabled = false;
        if (tiempo < 0f)
        {
            checkMan.isOn = false;
            checkWoman.isOn = false;
        }
    }
    public void AllTrue()
    {
        tiempo = 1f;
        txtInfo.text = "Ok";
        _btnSave.enabled = true;
    }
}