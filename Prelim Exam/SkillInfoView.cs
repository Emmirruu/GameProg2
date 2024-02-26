using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkillInfoView : MonoBehaviour
{
    public Challenger challenger;

    public TextMeshProUGUI skillName;
    public TextMeshProUGUI skillDes;


    public void DisplayPassiveSkill(Challenger challenger)
    {
        skillName.text = "[Passive]  " + challenger.pskillName;
        skillDes.text = challenger.pskillDes;

    }

    public void DisplayFirstSkill(Challenger challenger)
    {
        skillName.text = "[1st Skill]  " + challenger.s1Name + "  Unlocked at: Lv" + challenger.s1reqLv.ToString() + "  MP Cost: " + challenger.s1manaCost.ToString();
        skillDes.text = challenger.s1Des;

    }

    public void DisplaySecondSkill(Challenger challenger)
    {
        skillName.text = "[2nd Skill]  " + challenger.s2Name + "  Unlocked at: Lv" + challenger.s2reqLv.ToString() + "  MP Cost: " + challenger.s2manaCost.ToString();
        skillDes.text = challenger.s2Des;

    }
    public void DisplayUltimateSkill(Challenger challenger)
    {
        skillName.text = "[Ultimate]  " + challenger.usName + "  Unlocked at: Lv" + challenger.usReqLv.ToString() + "  MP Cost: " + challenger.usManaCost.ToString();
        skillDes.text = challenger.usDes;

    }
}
