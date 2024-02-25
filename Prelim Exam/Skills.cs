using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Skills", menuName = "ScriptableObjects/Skills")]
public class Skills : ScriptableObject
{
    // Start is called before the first frame update
    public string skillOwner;
    public string skillName;
    public SkillType skillType;
    public string des;
    public int manaCost;
    public int reqLv;
    public Sprite skillImage;
}