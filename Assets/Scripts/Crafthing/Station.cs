using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour
{
    private IngredientObject ingredient;
    public float procesTime;
      
    public void Input(IngredientObject objectItem)
    {
        ingredient = objectItem;
        procesTime = objectItem.procesTime;
        Proces();
    }
    public virtual void Proces()
    {
        ItemTimer();
    }
    private IEnumerator ItemTimer()
    {
        float procesTimeRunned = 0;
        while (procesTimeRunned <= procesTime)
        {
            procesTimeRunned = Time.deltaTime;
            Debug.Log(procesTimeRunned);
        }
        return null;
    }
    }