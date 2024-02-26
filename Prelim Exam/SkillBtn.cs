using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class SkillBtn : MonoBehaviour
{
    public Image skillImage;

    public void SetPassive(Challenger unit)
    {
        skillImage.sprite = unit.passiveImage;
    }

    public void SetFirstSkill(Challenger unit)
    {
        skillImage.sprite = unit.s1Image;
    }
    public void SetSecondSkill(Challenger unit)
    {
        skillImage.sprite = unit.s2Image;
    }
    public void SetUltSkill(Challenger unit)
    {
        skillImage.sprite = unit.usImage;
    }
}
