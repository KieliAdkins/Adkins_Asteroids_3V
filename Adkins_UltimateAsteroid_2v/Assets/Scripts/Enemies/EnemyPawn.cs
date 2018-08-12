using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPawn : EnemyController {

    // Start function
    private void Start()
    {
        // Assigning the script to the enemy controller
        EnemyController.ePawn = this;
    }

    // Enemy movement
    public virtual void Movement()
    {
        if (enemyShip.tf != null && GameManager.instance.target != null)
        {
            // Declaring our enemy's movement
            float step = enemyShip.moveSpeed * Time.deltaTime;
            enemyShip.tf.position = Vector3.MoveTowards(enemyShip.tf.position, GameManager.instance.target.transform.position, step);
        }
    }

    // Enemy Rotation
    public virtual void Rotation()
    {
        if (enemyShip.tf != null && GameManager.instance.target != null)
        {
            // Declaring our enemy's rotation
            Vector3 vectorToTarget = GameManager.instance.target.transform.position - enemyShip.tf.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            enemyShip.tf.rotation = Quaternion.Slerp(enemyShip.tf.rotation, q, Time.deltaTime * enemyShip.turnSpeed);
        }
    }
}
