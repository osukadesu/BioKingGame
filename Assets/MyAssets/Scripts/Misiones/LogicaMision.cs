using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaMision : MonoBehaviour
{
    [SerializeField] int nTargets;
    [SerializeField] Text txtMision;
    [SerializeField] GameObject vegetal;
    [SerializeField] GameObject animal;
    [SerializeField] GameObject monera;
    [SerializeField] GameObject protista;
    [SerializeField] GameObject misionV;

    void Start()
    {
        GOFalse();
        nTargets = GameObject.FindGameObjectsWithTag("myTarget").Length;
        txtMision.text = "Presiona W A S D para moverte a los objetivos." + " \n Restantes: " + nTargets;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "myTarget")
        {
            Destroy(other.transform.parent.gameObject);
            nTargets--;
            txtMision.text = "Presiona W A S D para moverte a los objetivos." + " \n Restantes: " + nTargets;
            if (nTargets <= 0)
            {
                txtMision.text = "Bien hecho!." + "\n Ahora dirigete a la escuela del reino vegetal.";
                GOTrue();
            }
        }
    }
    private void GOFalse()
    {
        misionV.SetActive(false);
        vegetal.SetActive(false);
        animal.SetActive(false);
        monera.SetActive(false);
        protista.SetActive(false);
    }
    private void GOTrue()
    {
        misionV.SetActive(true);
        vegetal.SetActive(true);
        animal.SetActive(true);
        monera.SetActive(true);
        protista.SetActive(true);
    }


}
