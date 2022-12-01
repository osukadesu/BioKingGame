using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimProto : MonoBehaviour
{
    private float rotationSpeed = 250f;
    void Update()
    {
        transform.Rotate(new Vector3(rotationSpeed * Time.deltaTime, 0, 0));
    }
}