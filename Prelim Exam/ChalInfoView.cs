using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ChalInfoView : MonoBehaviour
{
    public Challenger challenger;

    [Header("UI Headers")]
    public TextMeshProUGUI nameTMP;
    public TextMeshProUGUI classTMP;
    public TextMeshProUGUI hpTMP;
    public TextMeshProUGUI manaTMP;
    public TextMeshProUGUI maxlvTMP;
    public TextMeshProUGUI descriptionTMP;
    public Image chalImage;


    public void OnEnable()
    {
       // DisplayChallenger(challenger);
    }
    public void DisplayChallenger(Challenger challenger)
    {
        nameTMP.text = challenger.name;
        classTMP.text = "Class: " + challenger.chalClass.ToString() + " - Region: " + challenger.region.ToString() + " - Race: " + challenger.race.ToString();
        hpTMP.text = challenger.hp.ToString();
        manaTMP.text = challenger.mp.ToString();
        maxlvTMP.text = challenger.maxlv.ToString();
        descriptionTMP.text = challenger.des;
        chalImage.sprite = challenger.infoImage;

    }

    public void ClearView()
    {
        challenger = null;
        nameTMP.text = null;
        classTMP.text = null;
        hpTMP.text = null;
        manaTMP.text = null;
        maxlvTMP.text = null;
        descriptionTMP.text = null;
        chalImage.sprite = null;
    }
    public void OnDisable()
    {
        ClearView();
    }

}


