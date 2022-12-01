using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpObject : MonoBehaviour
{
    public GameObject objectToPickup;
    public GameObject mano;
    public GameObject pickedObject;
    public Transform brazos;
    public LogicaMision logicaMision;
    public PlayerMove playerMove;
    public void Coger1()
    {
        mano.SetActive(true);
        pickedObject = objectToPickup;
        pickedObject.GetComponent<CanChoose>().canChoose = false;
        pickedObject.transform.SetParent(brazos);
        pickedObject.transform.position = brazos.position;
        pickedObject.GetComponent<Rigidbody>().useGravity = false;
        pickedObject.GetComponent<Rigidbody>().isKinematic = true;
        logicaMision.GOTrue();
        logicaMision.txtMision.text = "Ahora llevalo a su reino.";
        logicaMision.mision1.SetActive(false);
        playerMove.anim.SetBool("Carryn", true);
        playerMove.speedmove = 4f;
        playerMove.speedrotation = 100f;
    }
    private void Start()
    {
        mano.SetActive(false);
    }
    public void Coger()
    {
        if (objectToPickup != null && objectToPickup.GetComponent<CanChoose>().canChoose == true && pickedObject == null)
        {
            Coger1();
        }
        else if (pickedObject != null)
        {
            Coger2();
        }
    }
    public void Coger2()
    {
        mano.SetActive(true);
        pickedObject.GetComponent<CanChoose>().canChoose = true;
        pickedObject.transform.SetParent(null);
        pickedObject.GetComponent<Rigidbody>().useGravity = true;
        pickedObject.GetComponent<Rigidbody>().isKinematic = false;
        pickedObject = null;
        playerMove.anim.SetBool("Carryn", false);
        playerMove.speedmove = 10f;
        playerMove.speedrotation = 190f;
    }
}