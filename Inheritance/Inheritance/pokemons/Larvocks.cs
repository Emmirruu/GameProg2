using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Larvocks : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2;
        name = "Larvocks";
        gender = Gender.Female;
        types = Types.Bug;
        type2 = Type2.None;
        hp = 60;
        atk = 20;
        defe = 30;
        speed = 20;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
