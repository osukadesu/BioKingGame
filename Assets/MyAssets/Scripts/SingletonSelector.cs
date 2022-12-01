using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonSelector : MonoBehaviour
{
    public static SingletonSelector singletonSelector;
    [SerializeField] Selector myselector;
    public bool man, woman;
    private void Start()
    {
        WhoIs();
    }
    private void Awake()
    {
        if (singletonSelector == null)
        {
            singletonSelector = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void WhoIs()
    {
        if (myselector.isman)
        {
            man = true;
            woman = false;
        }
        else
        {
            man = false;
            woman = true;
        }
    }
}
