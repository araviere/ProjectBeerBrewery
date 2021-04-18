using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    Inventory inventory;
    public GameObject objectButton;
    public Image objectImage;

    public void PickUp(GameObject player)
    {
            objectImage.enabled = true;

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == false)
                {
                    // Add item to inventory
                    inventory.isFull[i] = true;
                    Instantiate(objectButton, inventory.slots[i].transform, false);
                    Instantiate(objectImage, inventory.slots[i].transform, false);
                    
                    Destroy(gameObject);
                    Debug.Log(inventory);
                    break;
                }
            }
     }
}

