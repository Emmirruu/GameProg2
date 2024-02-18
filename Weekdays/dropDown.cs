using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropDown : MonoBehaviour
{
    public WeekDays days;
    // Start is called before t
    // e first frame update
    void Start()
    {
        switch (days)
        {
            case WeekDays.Monday: Debug.Log("Monday nanaman"); break;
            case WeekDays.Tuesday: Debug.Log("Tuesday pa lang"); break;
            case WeekDays.Wednesday: Debug.Log("Wednesday umay"); break;
            case WeekDays.Thursday: Debug.Log("Thursday naaa"); break;
            case WeekDays.Friday: Debug.Log("Friday aahh restday"); break;
            case WeekDays.Saturday: Debug.Log("Saturday pasok muna bago inom"); break;
            case WeekDays.Sunday: Debug.Log("Sunday lemme sleep"); break;

        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
