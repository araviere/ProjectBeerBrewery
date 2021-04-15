using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : Slot
{
    public override bool InterectactWithSlot(Object ingredient)
    {
        return true;
    }
}
