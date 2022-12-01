using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaberintoPlayer : MonoBehaviour
{
    [SerializeField] private ManagerJoystick managerJoystick;
    public float speedmove = 10f, speedrotation = 190f;
    public float inputy = 0f, inputz = 0f;
    void Update()
    {
        inputy = managerJoystick.inputHorizontal();
        inputz = managerJoystick.inputVertical();
        transform.Rotate(0, inputy * Time.deltaTime * speedrotation, 0);
        transform.Translate(0, 0, inputz * Time.deltaTime * speedmove);
    }
}
