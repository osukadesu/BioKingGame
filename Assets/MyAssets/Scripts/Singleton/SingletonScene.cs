using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonScene : MonoBehaviour
{
    public static SingletonScene singletonScene;

    [SerializeField] GameObject canvas;
    bool canvasBool;
    private void Start()
    {
        canvas.SetActive(false);
    }
    private void Awake()
    {
        if (singletonScene == null)
        {
            singletonScene = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Interrptor()
    {
        canvasBool = !canvasBool;
        if (canvasBool)
        {
            canvas.SetActive(true);
        }

        if (canvasBool == false)
        {
            canvas.SetActive(false);
        }
    }
}
