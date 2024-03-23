using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiator : Swordsman
{
    public override void JobClass()
    {
        base.JobClass();
        Debug.Log("2nd Class: Gladiator");
    }
}
