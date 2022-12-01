using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePresentacion : MonoBehaviour
{
    private float tiempo = 3.53f;
    public void Update()
    {
        tiempo = tiempo - 1 * Time.deltaTime;

        if (tiempo < 1f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
