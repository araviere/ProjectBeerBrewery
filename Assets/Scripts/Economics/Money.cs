using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int money = 0;
    public Text moneyText;

    void Update()
    {
        
    }

    void Awake()
    {
        moneyText.text = "Wallet: " + money.ToString();
    }

    public int GetMoney()
    {
        return money;
    }

    public void SetMoney(int moneyValue)
    {
        money += moneyValue; 
    }
}
