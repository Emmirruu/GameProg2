using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper: Archer
{
    public override void JobClass()
    {
        base.JobClass();
        Debug.Log("2nd Class: Sniper");
    }
}
