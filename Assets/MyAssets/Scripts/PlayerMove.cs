using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private ManagerJoystick managerJoystick;
    public float speedmove = 10f, speedrotation = 190f;
    public float inputy = 0f, inputz = 0f;
    public Animator anim;
    void Update()
    {
        inputy = managerJoystick.inputHorizontal();
        inputz = managerJoystick.inputVertical();
        transform.Rotate(0, inputy * Time.deltaTime * speedrotation, 0);
        transform.Translate(0, 0, inputz * Time.deltaTime * speedmove);
        if (inputy == 0 && inputz == 0)
        {
            anim.SetBool("Running", false);
            anim.SetBool("Carry", false);
        }
        else
        {
            anim.SetBool("Carry", true);
            anim.SetBool("Running", true);
        }
    }
}