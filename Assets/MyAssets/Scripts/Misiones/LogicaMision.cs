using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaMision : MonoBehaviour
{
    public int nTargets;
    public GameObject tutorial;
    public int exp;
    public Text txtMision;
    public GameObject schools;
    public GameObject mision1;
    public GameObject matera;
    void Start()
    {
        GOFalse();
        nTargets = GameObject.FindGameObjectsWithTag("myTarget").Length;
        txtMision.text = "mueve el touch para moverte a los objetivos." + " \n Restantes: " + nTargets;
        LogicaTutorial();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "myTarget")
        {
            Destroy(other.transform.parent.gameObject);
            nTargets--;
            exp++;
            txtMision.text = "mueve el touch para moverte a los objetivos." + " \n Restantes: " + nTargets;
            if (nTargets == 0)
            {
                mision1.SetActive(true);
                matera.SetActive(true);
                txtMision.text = "Bien hecho!." + "\n Mision 1: Toma el objeto.";
            }
        }
    }
    public void GOFalse()
    {
        matera.SetActive(false);
        mision1.SetActive(false);
        schools.SetActive(false);
    }
    public void GOTrue()
    {
        schools.SetActive(true);
    }
    private void LogicaTutorial()
    {
        if (exp >= 5)
        {
            tutorial.SetActive(false);
        }
        else
        {
            tutorial.SetActive(true);
        }
    }
}