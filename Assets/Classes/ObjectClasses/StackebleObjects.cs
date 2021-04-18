using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu]
public class StackebleObjects : Object
{
    public int stackAmount = 1;
    public Text amountText;

    private void Awake()
    {
        SetStack(0);
    }

    public int GetStackAmount()
    {
        return stackAmount;
    }

    public void SetStack(int amount)
    {

        Debug.Log(1);
        amountText.text = ((stackAmount += amount).ToString() + "x");
    }
}
