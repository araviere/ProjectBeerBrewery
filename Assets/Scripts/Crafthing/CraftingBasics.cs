using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingBasics : MonoBehaviour
{
    private IngredientObject ingredient;
    public float procesTime;

    float procesTimeRunned = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (procesTimeRunned <= procesTime)
        {
            procesTimeRunned += Time.deltaTime;
            Debug.Log(procesTimeRunned);
        }
    }

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
        if (procesTimeRunned <= procesTime)
        {
            procesTimeRunned += Time.deltaTime;
            Debug.Log(Time.deltaTime);
        }
        return null;
    }
}
