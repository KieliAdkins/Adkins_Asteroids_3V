using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    // Declaring our variables
    public static EnemyController eController; 
    public static EnemyPawn ePawn;
    public static Enemy enemyShip; 

	// Use this for initialization
	void Start () {

        // Assigning the script to the enemy controller
        eController = this; 
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Calling the ship movement function
        enemyShip.Movement();

        // Calling the ship rotation function
        enemyShip.Rotation(); 
	}
}
