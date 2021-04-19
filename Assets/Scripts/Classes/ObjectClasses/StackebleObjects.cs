using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class StackebleObjects : Object
{
    private int stackAmount = 1;

    public int GetStackAmount()
    {
        return stackAmount;
    }


    public void SetStack(int amount)
    {
        stackAmount += amount;
    }
}
