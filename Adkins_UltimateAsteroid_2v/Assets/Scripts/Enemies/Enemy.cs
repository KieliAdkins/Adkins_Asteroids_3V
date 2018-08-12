using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : EnemyPawn {

    // Declaring our variables
    public float moveSpeed;
    public float turnSpeed;
    public AudioClip enemyHit;
    public Transform tf;
    public int pointWorth;
    public int playerHealthHit; 

    // Start function
    private void Start()
    {
        // Assigning the script to the enemy controller
        EnemyController.enemyShip = this;

        // Capturing the transform component
        tf = GetComponent<Transform>(); 
    }

    // Enemy movement
    public override void Movement()
    {
        // Calling the parent function
        base.Movement(); 
    }

    // Enemy Rotation
    public override void Rotation()
    {
        // Calling the parent function
        base.Rotation();
    }

    // Destroying the enemy on contact
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the object is not the boundary destroy both objects
        if (collision.gameObject.tag == "Laser")
        {
            // Playing audio
            AudioSource.PlayClipAtPoint(enemyHit, gameObject.transform.position);

            // Destroying the enemy and collision object
            Destroy(gameObject);

            // Adding points to player's score
            GameManager.playerScore.pScore += pointWorth;
        }

        if (collision.gameObject.tag == "Player")
        {
            // Playing audio
            AudioSource.PlayClipAtPoint(GameManager.instance.playerHitNoise, gameObject.transform.position);

            // Destroying the enemy and collision object
            Destroy(gameObject);

            // Player loses a life
            GameManager.instance.currentHealth -= playerHealthHit;
        }
    }

    // On destroy function
    private void OnDestroy()
    {
        // Remove from enemy spawn list
        GameManager.instance.numEnemySpawned -= 1;
    }
}
