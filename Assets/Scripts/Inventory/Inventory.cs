using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public int inventorySize;

    public GameObject panel;
    public GameObject UISlot;


    static bool InventoryOpen = false;
    public GameObject inventoryMenuUI;

    void Awake()
    {
        isFull = new bool[inventorySize];
        slots = new GameObject[inventorySize];   

        for(int i = 0; i < slots.Length;)
        {            
            GameObject b = Instantiate(UISlot.gameObject, panel.transform);
            slots[i] = b;

            i++;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Time.timeScale == 1f)
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
    }

    void OpenInventory()
    {
        inventoryMenuUI.SetActive(true);
        Time.timeScale = 0f;
        InventoryOpen = true;
    }
}
