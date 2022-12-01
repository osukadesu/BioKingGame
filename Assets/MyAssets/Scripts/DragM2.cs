using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragM2 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] RectTransform rectTransform;
    [SerializeField] Canvas myCanvas;
    [SerializeField] CanvasGroup myCanvasGroup;
    [SerializeField] Vector2 initPos;
    public Animator animg, animw;
    public Text txtGood;
    public Text txtWrong;
    public GameObject part1, part2, btNext;
    public int id;
    private void Start()
    {
        btNext.SetActive(false);
        part1.SetActive(true);
        part2.SetActive(false);
        txtGood.enabled = false;
        txtWrong.enabled = false;
        initPos = transform.position;
        animw.gameObject.SetActive(false);
        animg.gameObject.SetActive(false);
    }
    public void ResetPosition()
    {
        transform.position = initPos;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        myCanvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / myCanvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        myCanvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
}
