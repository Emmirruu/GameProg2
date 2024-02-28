using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loepoon : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        id = 2;
        name = "Loepoon";
        gender = Gender.Female;
        types = Types.Bug;
        type2 = Type2.None;
        hp = 109;
        atk = 20;
        defe = 80;
        speed = 10;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
