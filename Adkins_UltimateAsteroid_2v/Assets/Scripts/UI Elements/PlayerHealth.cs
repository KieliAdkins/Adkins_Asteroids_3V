using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    // Health information
    public Slider healthSlider;

    // Use this for initialization
    void Start () {
        // Setting this as the script
        GameManager.pHealth = this; 

        // Set the initial health of the player.
        GameManager.instance.currentHealth = GameManager.instance.startingHealth;

        // Setting the health slider value
        healthSlider.value = GameManager.instance.startingHealth;
    }
	
	// Update is called once per frame
	void Update () {
        // Setting the health slider value
        healthSlider.value = GameManager.instance.currentHealth;

        // If player has no health 
        if (GameManager.instance.currentHealth == 0)
        {
            // Loading player to lose screen
            SceneManager.LoadScene(1);
        }
    }
}
