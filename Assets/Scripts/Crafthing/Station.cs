using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : Object
{
    private IngredientObject ingredient;
    private int procesTime;
    private int procesTimeRunned = 0;
    public override string WhatYouCanDoWith()
    {
        return "open " + name + " with";
    }
    public override void InteractWith(GameObject player)
    {
        base.InteractWith(player);
    }
    public void Input(IngredientObject objectItem)
    {
        ingredient = objectItem;
        procesTime = objectItem.procesTime;
    }

    public virtual void Proces()
    {
        if(procesTimeRunned < procesTime)
        {
            procesTimeRunned++;
        }
        else if (procesTimeRunned == procesTime)
        {
            procesTimeRunned = 0;
        }
    }
}