using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;

    public static bool InventoryOpen = false;
    public GameObject inventoryMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (InventoryOpen)
            {
                Resume();
            }
            else
            {
                OpenInventory();
            }
        }
    }

    void Resume()
    {
        inventoryMenuUI.SetActive(false);
        Time.timeScale = 1f;
        InventoryOpen = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OpenInventory()
    {
        inventoryMenuUI.SetActive(true);
        Time.timeScale = 0f;
        InventoryOpen = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
