using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSlot : Slot
{
    public CraftingBasics crafthingStation;
    public override bool InterectactWithSlot(Object ingredient)
    {

        try
        {
            return Input(ingredient.GetComponent<IngredientObject>());
        }
        catch
        {
            return false;
        }
    }
    private bool Input(IngredientObject ingredient)
    {
        return crafthingStation.Input(ingredient);
    }
}
