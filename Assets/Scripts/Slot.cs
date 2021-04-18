using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Slot : MonoBehaviour, IDropHandler
{
    public GameObject slot;
    public Object itemInSlot;
    public Inventory inventory;
    public int i;
    


    public virtual bool InterectactWithSlot(Object ingredient)
    {
        Debug.Log(itemInSlot == null || itemInSlot.GetComponent<StackebleObjects>().name == ingredient.name);

            try
            {
                Debug.Log(itemInSlot.GetComponent<StackebleObjects>().name == ingredient.name? true : false);
                if(itemInSlot.GetComponent<StackebleObjects>().name == ingredient.name && itemInSlot != ingredient)
                {
                    itemInSlot.GetComponent<StackebleObjects>().SetStack(ingredient.GetComponent<StackebleObjects>().GetStackAmount()); 

                Destroy(ingredient.gameObject);
                }
                else
                {
                    itemInSlot = ingredient;
                    
                }
            }
            catch
            {
                itemInSlot = ingredient;
            }
            itemInSlot = ingredient;
            return true;

    }

    public virtual void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            Debug.Log(eventData.pointerPress.GetComponent<RectTransform>());
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = slot.GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragAndDrop>().droppedOnSlot = slot.GetComponent<Slot>().InterectactWithSlot(eventData.pointerPress.transform.GetComponent<Object>());
        }
    }
}
