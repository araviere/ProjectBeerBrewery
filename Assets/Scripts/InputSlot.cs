using System;
using System.Collections.Generic;
using UnityEngine;

public class InputSlot : Slot
{
    public CraftingBasics crafthingStation;
    public override bool InterectactWithSlot(Object ingredient)
    {
        try
        {
            Debug.Log(itemInSlot.GetComponent<StackebleObjects>().name == ingredient.name ? true : false);
            if (itemInSlot.GetComponent<StackebleObjects>().name == ingredient.name && itemInSlot != ingredient)
            {
                itemInSlot.GetComponent<StackebleObjects>().SetStack(ingredient.GetComponent<StackebleObjects>().GetStackAmount());

                Destroy(ingredient.gameObject);
                return false;
            }
            else
            {

                return false;

            }
        }
        catch
        {
            itemInSlot = ingredient;

            itemInSlot = ingredient;
            return Input(ingredient);
        }
    }
    private bool Input(Object ingredient)
    {
        return crafthingStation.Input(ingredient);
    }
}
