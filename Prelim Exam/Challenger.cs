using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Challenger", menuName = "ScriptableObjects/Challenger")]
public class Challenger : ScriptableObject
{

    // Start is called before the first frame update
    [Header("Challenger Info")]
    public int id;
    public new string name;
    public Region region;
    public Race race;
    public string job;
    public string des;
    public ChalClass chalClass;
    public int hp;
    public int mp;
    public int maxlv;
    public Sprite charImage;
    public Sprite infoImage;

    [Header("Passive Skill")]
    public string pskillName;
    public string pskillDes;
    public int pmanaCost;
    public int preqLv;
    public Sprite passiveImage;

    [Header("1st Skill")]
    public string s1Name;
    public string s1Des;
    public int s1manaCost;
    public int s1reqLv;
    public Sprite s1Image;

    [Header("2nd Skill")]
    public string s2Name;
    public string s2Des;
    public int s2manaCost;
    public int s2reqLv;
    public Sprite s2Image;

    [Header("Ultimate Skill")]
    public string usName;
    public string usDes;
    public int usManaCost;
    public int usReqLv;
    public Sprite usImage;
}
