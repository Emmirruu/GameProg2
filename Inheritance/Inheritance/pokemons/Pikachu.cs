using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikachu : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        id = 1;
        name = "Pikachu";
        gender = Gender.Male;
        types = Types.Electric;
        type2 = Type2.None;
        hp = 100;
        atk = 60;
        defe = 40;
        speed = 100;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
