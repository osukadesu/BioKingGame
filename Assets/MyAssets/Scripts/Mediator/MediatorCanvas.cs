using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MediatorCanvas : MonoBehaviour
{
    [SerializeField]
    private Sign_In _ingresar;

    [SerializeField]
    private Sign_Up _registrar;

    [SerializeField]
    private CharacterSelect _character;
    private void Awake()
    {
        _registrar.Configure(this);
        _ingresar.Configure(this);
        _character.Configure(this);
        _ingresar.Show();
        _registrar.MyOnClickUp();
        _registrar.Hide();
        _character.Hide();
    }
    public void ViewRegistrar()
    {
        _registrar.Show();
        _registrar.MyOnClickUp();
        _ingresar.Hide();
        _character.Hide();
    }
    public void imgFade()
    {
        _character.Hide();
        _registrar.Hide();
        _ingresar.Hide();
    }
    public void ViewIngresar()
    {
        _ingresar.Show();
        _ingresar.MyOnClickIn();
        _character.Hide();
        _registrar.Hide();
    }
    public void ViewSelect()
    {
        _ingresar.Hide();
        _registrar.Hide();
        _character.Show();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
}