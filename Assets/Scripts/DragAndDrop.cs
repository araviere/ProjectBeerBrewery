using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] Canvas canvas;
    RectTransform rectTransform;
    CanvasGroup canvasGroup;
    Vector3 defaultPos;

    public bool droppedOnSlot;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        defaultPos = GetComponent<RectTransform>().localPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        droppedOnSlot = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        StartCoroutine(DropInSlot());
        canvasGroup.blocksRaycasts = true;        
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    IEnumerator DropInSlot()
    {
        yield return new WaitForEndOfFrame();
        if(droppedOnSlot == false)
        {
            Debug.Log(rectTransform.gameObject);
            this.rectTransform.localPosition = defaultPos;
        }
        else
        {                        
            defaultPos = this.rectTransform.localPosition;
        }
    }
}
