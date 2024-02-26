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
    public GameObject passiveBtn;
    public GameObject skill1Btn;
    public GameObject skill2Btn;
    public GameObject ultimateBtn;
    public SkillInfoView skillInfoView;


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

        SkillBtn pSkillBtn = passiveBtn.GetComponent<SkillBtn>(); //passive
        pSkillBtn.SetPassive(challenger);

        Button passiveButton = passiveBtn.GetComponent<Button>();
        passiveButton.onClick.AddListener(() => skillInfoView.DisplayPassiveSkill(challenger));

        SkillBtn skillBtn1 = skill1Btn.GetComponent<SkillBtn>(); //1st Skill
        skillBtn1.SetFirstSkill(challenger);

        Button firstSkill = skill1Btn.GetComponent<Button>();
        firstSkill.onClick.AddListener(() => skillInfoView.DisplayFirstSkill(challenger));

        SkillBtn skillBtn2 = skill2Btn.GetComponent<SkillBtn>(); //2nd Skill
        skillBtn2.SetSecondSkill(challenger);

        Button secondSkill = skill2Btn.GetComponent<Button>();
        secondSkill.onClick.AddListener(() => skillInfoView.DisplaySecondSkill(challenger));

        SkillBtn usBtn = ultimateBtn.GetComponent<SkillBtn>(); //Ult
        usBtn.SetUltSkill(challenger);

        Button ultSkill = ultimateBtn.GetComponent<Button>();
        ultSkill.onClick.AddListener(() => skillInfoView.DisplayUltimateSkill(challenger));

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


