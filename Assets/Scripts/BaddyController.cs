using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaddyController : MonoBehaviour
{
    public PlayerHealthManager playerHealthManager;

    public int baddyHealth;
    public int damage;


    public void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {
            playerHealthManager.currentHealth = playerHealthManager.currentHealth - damage;
            playerHealthManager.UpdateHealthInformation();
        }
    }
}
