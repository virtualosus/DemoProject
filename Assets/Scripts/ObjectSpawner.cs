using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] spawnPoints;

    public GameObject baddyGameObject;
    public GameObject goodyGameObject;

    public int lastSpawnNumber;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The array is " + spawnPoints.Length + " long");
        BaddySpawner();
        GoodySpawner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BaddySpawner()
    {
        int randomNumber = Random.Range(1, 10);
        Debug.LogWarning("The random number for baddy is " + randomNumber);

        while (lastSpawnNumber == randomNumber)
        {
            BaddySpawner();
        }

        Instantiate(baddyGameObject, spawnPoints[randomNumber].transform);

        lastSpawnNumber = randomNumber;
    }

    public void GoodySpawner()
    {
        int randomNumber = Random.Range(1, 10);
        
        Debug.LogWarning("The random number for goody is " + randomNumber);

        while (lastSpawnNumber == randomNumber)
        {
            GoodySpawner();
        }

        Instantiate(goodyGameObject, spawnPoints[randomNumber].transform);

        lastSpawnNumber = randomNumber;
    }
}
