using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M2Proto : MonoBehaviour
{
    private float rotationSpeed = 250f;
    void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }
}