using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaddyController : MonoBehaviour
{
    public PlayerHealthManager playerHealthManager;
    public ObjectSpawner objectSpawner;

    public int baddyHealth;
    public int damage;

    private void Start()
    {
        playerHealthManager = FindAnyObjectByType<PlayerHealthManager>();
        objectSpawner = FindAnyObjectByType<ObjectSpawner>();
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerHealthManager.currentHealth = playerHealthManager.currentHealth - damage;
            playerHealthManager.UpdateHealthInformation();

            Destroy(this.gameObject);
            objectSpawner.BaddySpawner();

        }
    }
}
