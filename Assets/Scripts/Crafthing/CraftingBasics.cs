using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingBasics : MonoBehaviour
{
    private IngredientObject ingredient;
    public OutputSlot output;
    public InputSlot input;
    public float procesTime;
    public Image timerCyrcel;
    public Text timerText;

    float procesTimeRunned = 0;

    public bool Input(Object objectItem)
    {
        //Debug.Log(output.itemInSlot.name == ingredient.suckesfullCreatedOutput.name || output.itemInSlot == null  ? true : false);


            ingredient = objectItem.GetComponent<IngredientObject>();
            procesTime = objectItem.GetComponent<IngredientObject>().procesTime;
            Proces();
            return true;
    }
    public virtual void Proces()
    {
        StartCoroutine(ItemTimer());

    }
    private IEnumerator ItemTimer()
    {

        for (float procesTimeRunned = 0; procesTimeRunned <= procesTime;)
        {
            procesTimeRunned += Time.deltaTime;
            Timer((int)(procesTime - procesTimeRunned));


            yield return new WaitForSeconds(Time.deltaTime);
        }
        Output();
        procesTime = 0;
        timerCyrcel.fillAmount = 0;
        timerText.text = "";
    }
    private void Timer(int time)
    {
        timerCyrcel.fillAmount = time / procesTime;
        int minutes = 0;
        if (time >= 60)
        {
            time -= 60;
            minutes++;
        }
        timerText.text = minutes > 0 ? minutes + ":" + time : time.ToString();
    }
    private void Output()
    {
        if (output.itemInSlot == null)
        {
            GameObject obj = Instantiate(ingredient.suckesfullCreatedOutput, output.transform.position, output.transform.rotation, transform.parent = GameObject.Find("InteractWithUI").transform);
            Destroy(input.itemInSlot.gameObject);
        }
        else if(output.itemInSlot == ingredient.suckesfullCreatedOutput)
        {
            output.itemInSlot.GetComponent<StackebleObjects>().SetStack(ingredient.GetStackAmount());
        }
    }
}
