using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ChalBTN : MonoBehaviour
{
    public TextMeshProUGUI chalNameTxt;
    public TextMeshProUGUI classText;
    public Image imageBtn;

    public void SetChalData(Challenger unit)
    {
       chalNameTxt.text = unit.name;
       classText.text = unit.chalClass.ToString();
       imageBtn.sprite = unit.charImage;
    }
}

