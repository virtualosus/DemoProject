using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodyController : MonoBehaviour
{
    public ScoreManager scoreManager;
    public ObjectSpawner objectSpawner;

    public int points;


    private void Start()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
        objectSpawner = FindAnyObjectByType<ObjectSpawner>();
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            scoreManager.currentScore = scoreManager.currentScore + points;
            scoreManager.UpdateScoreInformation();

            Destroy(this.gameObject);
            objectSpawner.GoodySpawner();
        }
    }
}
