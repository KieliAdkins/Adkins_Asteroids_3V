using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Defining variables
    public static GameManager instance;
    public static Score playerScore;
    public static PlayerHealth pHealth;
    public List<GameObject> enemyList = new List<GameObject>();
    public int numEnemySpawned;
    public int numToSpawn;

    internal Quaternion rotation;
    public GameObject target;

    public AudioClip playerHitNoise;


    // Use this for initialization and destruction of duplicate Game Managers
    void Awake()
    {
        // Ensuring that the Game manager is loaded
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        // Ensuring that the Game manager is not overwritten
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Spawning the enemy
    void SpawnEnemy()
    {
        // If there are less than 3 enemies spawned create more
        if (numEnemySpawned <= numToSpawn)
        {
            int whichItem = Random.Range(0, enemyList.Count);
            Vector3 spawnPoint = new Vector3(Random.Range(-3.35f, 3.35f), 5, 0);
            Quaternion spawnRotation = Quaternion.identity;
            GameObject myEnemy = Instantiate(enemyList[whichItem], spawnPoint, spawnRotation) as GameObject;
            myEnemy.transform.position = spawnPoint;
            numEnemySpawned++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Calling the function to instantiate enemies
        SpawnEnemy();
	}
}
