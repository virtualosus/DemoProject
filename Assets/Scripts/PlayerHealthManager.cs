using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    // added text mesh pro library
using UnityEngine.UI;   //added UI library


public class PlayerHealthManager : MonoBehaviour
{
    public Slider healthSlider;     //public reference to type Slider named healthSlider

    public Image healthSliderFill;      //public reference to type Image named healthSliderFIll

    public TMP_Text playerHealthText;       //public ref to tyoe TMP text called playerHealthText

    public int maxHealth;       //public ref to type integer named maxHealth
    public int currentHealth;   //public ref to type integer named currentHealth

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;      //set current to max

        healthSlider.value = currentHealth;     //set slider current value to current health

        playerHealthText.color = Color.green;   //set text colour to gree

        playerHealthText.text = "Current health = " + currentHealth; //displaying message via text mesh pro

        //Debug.LogError("Current health = " + currentHealth);
    }


    public void UpdateHealthInformation()
    {
        if (currentHealth <= 0)     //condition statement checking if health is 0 or below
        {
            healthSlider.value = currentHealth;    //set slider current value to current health 

            playerHealthText.text = "Player has died!!!";  //displaying message via text mesh pro

            //Debug.LogError("Player has died!!!");
        }
        else                        //opposite of health at 0 or below
        {
            healthSlider.value = currentHealth; //set slider current value to current health 

            if (currentHealth >= 80)        //conditional - health 80 or above
            {
                healthSliderFill.color = Color.green;       //slider fill green
                playerHealthText.color = Color.green;       //text green
            }
            else if (currentHealth >= 30 && currentHealth < 80)     //conditional - health between 30 & 80
            {
                healthSliderFill.color = Color.yellow;      //slider yellow
                playerHealthText.color = Color.yellow;      //text yello
            }
            else if (currentHealth < 30)                //conditional - health below 30
            {
                healthSliderFill.color = Color.red;         //slider red
                playerHealthText.color = Color.red;         //text red
            }

            playerHealthText.text = "Current health = " + currentHealth;  //-------------------------

            //Debug.LogError("Current health = " + currentHealth);
        }
    }
}
