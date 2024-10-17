using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int currentScore;

    public void UpdateScoreInformation()
    {
        if (currentScore >= 100)
        {
            Debug.LogError("Player has won!!!");
        }
        else
        {
            Debug.LogError("Current score = " + currentScore);
        }
    }
}
