using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanChoose : MonoBehaviour
{
    public GameObject mano;
    public bool canChoose = true;

    private void Start()
    {
        mano.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Brazos")
        {
            mano.SetActive(true);
            other.GetComponentInParent<PickUpObject>().objectToPickup = this.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Brazos")
        {
            mano.SetActive(false);
            other.GetComponentInParent<PickUpObject>().objectToPickup = null;
        }
    }
}