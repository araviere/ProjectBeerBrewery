using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchPanel : MonoBehaviour
{
    public List<GameObject> craftingStations = new List<GameObject>();
    public GameObject myCanvas;

    public void EnableUI()
    {
        foreach(GameObject gameObject in craftingStations)
        {
            gameObject.SetActive(false);
        }

        myCanvas.SetActive(true);
    }

}
