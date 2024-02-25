using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Challenger", menuName = "ScriptableObjects/Challenger")]
public class Challenger : ScriptableObject
{

    // Start is called before the first frame update
    public int id;
    public string name;
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
}
