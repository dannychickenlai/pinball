using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private int _score;
    
    void Start()
    {
        _score = 0;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Bottom")
        {
            
            var bumperValue = other.gameObject.GetComponentInParent<BumperValues>();

            if (bumperValue != null)
            {
                Debug.Log($"bumper value is {bumperValue.ScoreDelta}");
                _score += bumperValue.ScoreDelta;
            }
            else
            {
                Debug.Log($"bumper value not found");
            }

            Debug.Log($"collided with bumper, score = {_score}");
            PinballEventManager.OnBallCollided(_score);
        }
    }
}
