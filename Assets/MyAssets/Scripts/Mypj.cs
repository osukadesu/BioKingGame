using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mypj : MonoBehaviour
{
    public Selector myselector;
    [SerializeField] private GameObject boy, girl;

    private void Start()
    {
        WhoIs();
    }
    public void WhoIs()
    {
        if (myselector.isman)
        {
            boy.SetActive(true);
            girl.SetActive(false);
        }
        else
        {
            boy.SetActive(false);
            girl.SetActive(true);
        }
    }
}
