using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int currentScore;

    public TMP_Text playerScoreText;

    public void UpdateScoreInformation()
    {
        if (currentScore >= 100)
        {
            playerScoreText.text = "Player has won!!!";

            Debug.LogError("Player has won!!!");
        }
        else
        {


            playerScoreText.text = "Current score = " + currentScore;

            Debug.LogError("Current score = " + currentScore);
        }
    }
}
