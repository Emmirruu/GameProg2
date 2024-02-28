using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ratbusaur : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2;
        name = "Ratbusaur";
        gender = Gender.Male;
        types = Types.Dragon;
        type2 = Type2.Dark;
        hp =120;
        atk = 60;
        defe = 45;
        speed = 160;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
