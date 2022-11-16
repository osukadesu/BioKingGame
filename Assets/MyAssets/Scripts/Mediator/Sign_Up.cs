using UnityEngine;
using UnityEngine.UI;

public class Sign_Up : MonoBehaviour
{
    [SerializeField]
    private Button _btnCharacterSelect;

    [SerializeField]
    private Button _btningresar;

    [SerializeField]
    private GameObject Canvas;
    private MediatorCanvas _mediator;

    [SerializeField]
    private Animator leftUp, rigthUp;
    private void Awake()
    {
        leftUp.enabled = false;
        rigthUp.enabled = false;
        _btnCharacterSelect.onClick.AddListener(() => _mediator.ViewSelect());
        _btningresar.onClick.AddListener(() => _mediator.ViewIngresar());
    }
    public void MyOnClickUp()
    {
        leftUp.enabled = true;
        rigthUp.enabled = true;
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