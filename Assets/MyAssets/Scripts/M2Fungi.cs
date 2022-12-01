using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M2Fungi : MonoBehaviour
{
    [SerializeField] private GameObject fungi;
    private float rotationSpeed = 250f;
    void Update()
    {
        transform.RotateAround(fungi.transform.position, fungi.transform.forward, rotationSpeed * Time.deltaTime);
    }
}
