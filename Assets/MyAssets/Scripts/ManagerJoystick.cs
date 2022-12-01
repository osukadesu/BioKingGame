using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ManagerJoystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private Image img1, img2;
    private Vector2 posInput;
    void Start()
    {
        img1 = GetComponent<Image>();
        img2 = transform.GetChild(0).GetComponent<Image>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            img1.rectTransform, eventData.position, eventData.pressEventCamera, out posInput))
        {
            posInput.x = posInput.x / (img1.rectTransform.sizeDelta.x);
            posInput.y = posInput.y / (img1.rectTransform.sizeDelta.y);

            if (posInput.magnitude > 1.0f)
            {
                posInput = posInput.normalized;
            }

            img2.rectTransform.anchoredPosition = new Vector2(
            posInput.x * (img1.rectTransform.sizeDelta.x / 2),
            posInput.y * (img1.rectTransform.sizeDelta.y / 2));
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        posInput = Vector2.zero;
        img2.rectTransform.anchoredPosition = Vector2.zero;
    }
    public float inputHorizontal()
    {
        if (posInput.x != 0)
        {
            return posInput.x;
        }
        return Input.GetAxis("Horizontal");

    }
    public float inputVertical()
    {
        if (posInput.y != 0)
        {
            return posInput.y;
        }
        return Input.GetAxis("Vertical");
    }
}
