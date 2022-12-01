using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiFx : MonoBehaviour
{
    [SerializeField] private GameObject Mask;
    private float rotationSpeed = -150f;
    void Update()
    {
        transform.RotateAround(Mask.transform.position, Mask.transform.forward, rotationSpeed * Time.deltaTime);
    }
}