using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Adventurer
{
    public override void JobClass()
    {
        base.JobClass();
        Debug.Log("1st Class: Swordsman");
    }
}
