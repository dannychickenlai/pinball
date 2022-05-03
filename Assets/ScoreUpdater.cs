using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    private void OnEnable()
    {
        PinballEventManager.BallCollided += PinballEventManager_BallCollided;
    }

    private void OnDisable()
    {
        PinballEventManager.BallCollided -= PinballEventManager_BallCollided;
    }

    private void PinballEventManager_BallCollided(int score)
    {
        //var x = this;
        var uiText = this.gameObject.GetComponentInParent<UnityEngine.UI.Text>();
        if (uiText != null)
        {
            uiText.text = score.ToString();
        }
    }
}
