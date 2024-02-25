using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ChangePanel : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject nextPanel;
    public GameObject classPanel;
    public void Changepanel()
    {
        currentPanel.gameObject.SetActive(false); 
        nextPanel.gameObject.SetActive(true);
        classPanel.gameObject.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
