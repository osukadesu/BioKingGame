using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Presentacion : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;

    private MediatorCanvas _mediator;

    private float tiempo = 3.5f;

    void Update()
    {
        tiempo = tiempo - 1 * Time.deltaTime;
        
        if (tiempo < 1f)
        {
            _mediator.ViewIngresar();
        }
    }

    public void Configure(MediatorCanvas mediator)
    {
        _mediator = mediator;
    }

    public void Show()
    {
        canvas.SetActive(true);
    }

    public void Hide()
    {
        canvas.SetActive(false);
    }
}
