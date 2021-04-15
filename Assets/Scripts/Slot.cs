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

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Inventory>();
    }
    void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }
    }
    


    public virtual bool InterectactWithSlot(Object ingredient)
    {
        Debug.Log(itemInSlot == null || itemInSlot.GetComponent<StackebleObjects>().name == ingredient.name);
        if (itemInSlot ==  null|| itemInSlot.GetComponent<StackebleObjects>().name == ingredient.name)
        {
            try
            {
                Debug.Log(itemInSlot.GetComponent<StackebleObjects>().name == ingredient.name? true : false);
                if(itemInSlot.GetComponent<StackebleObjects>().name == ingredient.name)
                {
                    itemInSlot.GetComponent<StackebleObjects>().SetStack(ingredient.GetComponent<StackebleObjects>().GetStackAmount());
                    Destroy(ingredient);
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
        else
            return false;
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
