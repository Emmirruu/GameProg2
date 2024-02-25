using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ChalSelection : MonoBehaviour
{
    public ChalManager chalManager;
    public Transform parentPos;
    public GameObject chalButtonPrefab;
    public ChalInfoView chalInfoView;
    public GameObject infoPanel;
    public GameObject chalSelection;
    public GameObject classPanel;

    void Start()
    {
        Debug.Log(chalManager.challengers.Count());
        foreach (Challenger c in chalManager.challengers)
        {
            
            GameObject buttonPrefab = Instantiate(chalButtonPrefab, parentPos);
            ChalBTN chalBTN = buttonPrefab.GetComponent<ChalBTN>();
            chalBTN.SetChalData(c);

            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => chalInfoView.DisplayChallenger(c));

            button.onClick.AddListener(() => infoPanel.gameObject.SetActive(true));
            button.onClick.AddListener(() => chalSelection.gameObject.SetActive(false));
            button.onClick.AddListener(() => classPanel.gameObject.SetActive(false));

        }

    }

}