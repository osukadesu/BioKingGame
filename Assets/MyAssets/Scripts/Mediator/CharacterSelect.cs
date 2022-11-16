using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField]
    private GameObject Canvas;

    [SerializeField]
    private Button _btnSave;

    [SerializeField]
    private Button _btnBack;

    private MediatorCanvas _mediator;
    private void Awake()
    {
        _btnSave.onClick.AddListener(() => _mediator.StartGame());
        _btnBack.onClick.AddListener(() => _mediator.ViewRegistrar());
    }

    public void Configure(MediatorCanvas mediator)
    {
        _mediator = mediator;
    }

    public void Show()
    {
        Canvas.SetActive(true);
    }

    public void Hide()
    {
        Canvas.SetActive(false);
    }
}
