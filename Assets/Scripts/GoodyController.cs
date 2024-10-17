using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodyController : MonoBehaviour
{
    public ScoreManager scoreManager;

    public int points;


    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            scoreManager.currentScore = scoreManager.currentScore + points;
            scoreManager.UpdateScoreInformation();
        }
    }
}
