using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerPawn
{
    // Defining variables
    public float moveSpeed;
    public float turnSpeed;
    public Transform tf;
    public GameObject laser;
    public Transform laserSpawn;
    internal Quaternion rotation;

    public AudioClip playerHitNoise;

    // Use this for initialization
    void Start()
    {
        // Acquiring component for movement
        tf = GetComponent<Transform>();

        // Assigning the script to the player controller
        PlayerController.starship = this;
    }

    // Move function
    public override void Move()
    {
        // Calling the pawn function
        base.Move(); 
    }

    // Move function
    public override void Shoot()
    {
        // Calling the pawn function
        base.Shoot();
    }

    void OnDestroy()
    {
        // Moving player back to the center of the game
        // Instantiate(starship.laser, starship.laserSpawn.position, starship.laserSpawn.rotation);

        // Player loses a life
        GameManager.pHealth.currentHealth -= 25;
    }

}
