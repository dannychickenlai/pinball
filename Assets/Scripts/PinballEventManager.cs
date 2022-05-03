//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PinballEventManager : MonoBehaviour
{
    //
    public static event UnityAction<int> BallCollided;

    //
    public static void OnBallCollided(int score)
    {
        BallCollided?.Invoke(score);
    }
}
