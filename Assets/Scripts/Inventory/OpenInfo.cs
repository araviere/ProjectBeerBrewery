using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInfo : MonoBehaviour
{
    public List<GameObject> infoPanel = new List<GameObject>();
    public GameObject currentPanel;

    public void EnablePanel()
    {
        foreach (GameObject gameObject in infoPanel)
        {
            gameObject.SetActive(false);
        }

        currentPanel.SetActive(true);

    }

    public void CloseUI()
    {
        foreach (GameObject gameObject in infoPanel)
        {
            gameObject.SetActive(false);
        }

    }
}
