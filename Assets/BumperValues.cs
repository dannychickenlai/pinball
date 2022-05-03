using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperValues : MonoBehaviour
{
    [Header("Scores Changes")] 
    [SerializeField] 
    int scoreDelta = 2;

    public int ScoreDelta
    {
        get => scoreDelta;
    }
}
