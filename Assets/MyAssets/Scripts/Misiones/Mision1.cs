using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mision1 : MonoBehaviour
{
    public LogicaMision logicaMision;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            logicaMision.GOTrue();
            logicaMision.txtMision.text = "Ahora llevalo a su reino.";
            logicaMision.mision1.SetActive(false);
        }
    }
}