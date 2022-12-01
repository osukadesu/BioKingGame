using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mision1wIN : MonoBehaviour
{
    public LogicaMision logicaMision;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Matera")
        {
            logicaMision.txtMision.text = "Felicidades has ganado.";
            SceneManager.LoadScene(3);
        }
    }
}