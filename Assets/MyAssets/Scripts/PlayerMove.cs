using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float speedmove = 10f, speedrotation = 190f;
    private float inputy = 0f, inputz = 0f;
    [SerializeField] private Animator anim;
    bool cursorBool;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        inputy = Input.GetAxis("Horizontal");
        inputz = Input.GetAxis("Vertical");

        transform.Rotate(0, inputy * Time.deltaTime * speedrotation, 0);
        transform.Translate(0, 0, inputz * Time.deltaTime * speedmove);
        if (inputy == 0 && inputz == 0)
        {
            anim.SetBool("Running", false);
        }
        else
        {
            anim.SetBool("Running", true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EnableCursor();
        }
    }
    private void EnableCursor()
    {
        cursorBool = !cursorBool;
        if (cursorBool)
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (cursorBool == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}