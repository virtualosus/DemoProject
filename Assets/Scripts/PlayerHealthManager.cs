using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        Debug.LogError("Current health = " + currentHealth);
    }


    public void UpdateHealthInformation()
    {
        if (currentHealth <= 0)
        {
            Debug.LogError("Player has died!!!");
        }
        else
        {
            Debug.LogError("Current health = " + currentHealth);
        }
    }
}
