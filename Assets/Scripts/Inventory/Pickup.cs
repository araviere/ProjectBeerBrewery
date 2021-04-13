using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    Inventory inventory;
    //public GameObject objectButton;
    public Image objectImage;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Inventory>();
        objectImage.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == false)
                {
                    // Add item to inventory
                    objectImage.enabled = true;
                    inventory.isFull[i] = true;
                    //Instantiate(objectButton, inventory.slots[i].transform, false);
                    Instantiate(objectImage, inventory.slots[i].transform, false);
                    

                    Destroy(gameObject);
                    Debug.Log(inventory);
                    break;
                }
            }
        }
    }
}
