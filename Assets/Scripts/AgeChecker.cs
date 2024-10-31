using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeChecker : MonoBehaviour
{
    private int userAge = 25;


    // Start is called before the first frame update
    void Start()
    {
        AgeCheckProcess();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AgeCheckProcess()
    {
        if (userAge >= 0 && userAge <= 12)
        {
            Debug.Log("You are a child!");
        }
        else if (userAge >= 13 && userAge <= 19)
        {
            Debug.Log("You are a teenager");
        }
        else if(userAge >= 20)
        {
            Debug.Log("You are old!");
        }
    }
}
