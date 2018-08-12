using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPawn : PlayerController {

    // Start function
    private void Start()
    {
        // Assigning the script to the player controller
        PlayerController.pawn = this; 
    }

    // Movement function
    public virtual void Move()
    {
        // if statement for up key controlled movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //  Checking for transform component
            if (starship.tf != null)
            {
                starship.tf.position = starship.tf.position + (GetComponent<Transform>().up * starship.moveSpeed);
            }
        }

        // if statement for right key controlled movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //  Checking for transform component
            if (starship.tf != null)
            {
                starship.tf.position = starship.tf.position + (GetComponent<Transform>().right * starship.moveSpeed);
                starship.tf.Rotate(0, -starship.turnSpeed, 0);
            }
        }

        // if statement for left key controlled movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //  Checking for transform component
            if (starship.tf != null)
            {
                starship.tf.position = starship.tf.position - (GetComponent<Transform>().right * starship.moveSpeed);
                starship.tf.Rotate(0, starship.turnSpeed, 0);
            }
        }

        // if statement for down key controlled movement
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //  Checking for transform component
            if (starship.tf != null)
            {
                starship.tf.position = starship.tf.position - (GetComponent<Transform>().up * starship.moveSpeed);
            }
        }

        //  Checking for transform component
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Checking for transform
            if (starship.tf != null)
            {
                // Calling the shoot function
                Shoot();
            }
        }
    }

    // Shoot function
    public virtual void Shoot()
    {
        // Instantiating the laser
        Instantiate(starship.laser, starship.laserSpawn.position, starship.laserSpawn.rotation);
    }
}
