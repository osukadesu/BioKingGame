using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public Vector3 ejes;
    public Transform playerBody;
    [Range(0, 1)] public float lerpValue;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, playerBody.position + ejes, lerpValue);
        transform.LookAt(playerBody);
    }
}
