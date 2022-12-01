using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nEXTqUEST : MonoBehaviour
{
    [SerializeField] GameObject quest1, quest2;
    private void Start()
    {
        quest1.SetActive(false);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Cube")
        {
            quest2.SetActive(true);
            quest1.SetActive(false);
        }
    }
}