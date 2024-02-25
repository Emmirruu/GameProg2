using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalManager : MonoBehaviour
{
    public Challenger[] challengers;
    private string folderPath = "Challenger"; // Folder name inside the Assets/Resources folder

    void Awake()
    {
        challengers = Resources.LoadAll<Challenger>(folderPath);
    }
}
