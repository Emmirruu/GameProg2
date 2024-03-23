using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer : MonoBehaviour
{
    public string name;
    public int attack;

    // Start is called before the first frame update
    public virtual void JobClass()
    {
        Debug.Log("Job: Adventurer");
    }

}
