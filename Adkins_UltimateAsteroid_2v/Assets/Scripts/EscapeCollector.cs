using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeCollector : MonoBehaviour {
    // Declaring our variables
    public int pointWorth; 

    // On collision function
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Subtracting from points
        GameManager.playerScore.pScore -= pointWorth;

        // Destroying the game object
        Destroy(collision.gameObject);
    }
}
