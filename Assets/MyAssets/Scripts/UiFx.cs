using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiFx : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0f, 0f, -120f * Time.deltaTime);
    }
}
