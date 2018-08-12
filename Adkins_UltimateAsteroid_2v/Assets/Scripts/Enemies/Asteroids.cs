using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour {

    // Declaring the variables
    public float moveSpeed;
    private Transform tf;
    public int pointWorth;
    public int playerHealthHit;
    public AudioClip asteroidHit; 


    // Use this for initialization
    void Start () {
        // Getting component movement for the asteroid
        tf = GetComponent<Transform>();

        // Declaring our asteroids movement
        if (GameManager.instance.target != null && tf != null)
        {
            float step = moveSpeed * Time.deltaTime;
            tf.position = Vector3.MoveTowards(tf.position, GameManager.instance.target.transform.position, step);
        }
    }
	
	// Update is called once per frame
	void Update () {
        // Asteroid movement
        tf.position = tf.position - (Vector3.up * moveSpeed * Time.deltaTime);
    }

    // On collision with objects
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If object is not the boundary destroy the asteroid and what it is colliding with
        if (collision.gameObject.tag == "Laser")
        {
            // Playing audio
            AudioSource.PlayClipAtPoint(asteroidHit, gameObject.transform.position);

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
