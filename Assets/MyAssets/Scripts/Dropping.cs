using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dropping : MonoBehaviour, IDropHandler
{
    public int id;
    [SerializeField] DragM2 dragM2;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DragM2>().id == id)
            {
                dragM2.btNext.SetActive(true);
                dragM2.animg.gameObject.SetActive(true);
                dragM2.animw.gameObject.SetActive(false);
                dragM2.txtGood.enabled = true;
                dragM2.txtWrong.enabled = false;
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
            }
            else
            {
                dragM2.btNext.SetActive(false);
                dragM2.animg.gameObject.SetActive(false);
                dragM2.animw.gameObject.SetActive(true);
                dragM2.txtGood.enabled = false;
                dragM2.txtWrong.enabled = true;
                eventData.pointerDrag.GetComponent<DragM2>().ResetPosition();
                dragM2.animw.gameObject.SetActive(false);
                dragM2.animw.gameObject.SetActive(true);
            }
        }
    }
    public void Next()
    {
        dragM2.part1.SetActive(false);
        dragM2.part2.SetActive(true);
        dragM2.txtGood.enabled = false;
        dragM2.txtWrong.enabled = false;
    }
    public void Next2()
    {
        SceneManager.LoadScene(1);
    }
}