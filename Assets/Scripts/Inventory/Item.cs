using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject item;
    public Sprite icon;
    public int itemID;
    public Item[] itemList;

    public int GetID()
    {
        return itemID;
    }

    public Sprite GetSprite()
    {
        return icon;
    }

    public GameObject GetGameObject()
    {
        return item;
    } 
}
