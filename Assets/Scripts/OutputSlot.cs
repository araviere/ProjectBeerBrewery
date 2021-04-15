using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputSlot : Slot
{
    public override bool InterectactWithSlot(Object ingredient)
    {
        return false;
    }
}
