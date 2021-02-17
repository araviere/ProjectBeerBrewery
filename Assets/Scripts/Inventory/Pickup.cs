using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    Inventory inventory;
    public GameObject objectButton;
    public Image objectImage;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        objectImage.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
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
}
