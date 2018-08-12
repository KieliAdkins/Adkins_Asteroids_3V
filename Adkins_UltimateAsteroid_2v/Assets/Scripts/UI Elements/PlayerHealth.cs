using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    // Health information
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;

    // Use this for initialization
    void Start () {
        // Setting this as the script
        GameManager.pHealth = this; 

        // Set the initial health of the player.
        currentHealth = startingHealth;

        // Setting the health slider value
        healthSlider.value = startingHealth;
    }
	
	// Update is called once per frame
	void Update () {
        // Setting the health slider value
        healthSlider.value = currentHealth;

        // If player has no health 
        if (currentHealth == 0)
        {
            // Loading player to lose screen
            SceneManager.LoadScene(1);
        }
    }
}
