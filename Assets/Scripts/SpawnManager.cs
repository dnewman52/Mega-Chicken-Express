using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    [System.Serializable]
    public class Spawnable {
        [HideInInspector]
        public string name;
        public GameObject prefab;
        public float SpawnBlockTime = 0f;
        public bool fixedSpawnPoint;
        public Vector3 SpawnOffset;
    }

    //public PlayerHealth playerHealth;       // Reference to the player's heatlh.
    public Spawnable[] entities;             // The prefab to be spawned. (PowerUp/Obstacle)
    //public float spawnTime = 3f;          
    public float spawnTimeMin = 1f;
    public float spawnTimeMax = 10f;
    public Transform[] spawnPoints;          // An array of the spawn points this enemy can spawn from.


    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        //InvokeRepeating("Spawn", 1f, Random.Range(spawnTimeMin, spawnTimeMax));
        Invoke("Spawn", Random.Range(spawnTimeMin, spawnTimeMax));
    }


    void Spawn()
    {
        // If game over
        /*if (playerHealth.currentHealth <= 0f)
        {
            // ... exit the function.
            return;
        }
        */

        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int entityChoice = Random.Range(0, entities.Length);
        if (entities[entityChoice].fixedSpawnPoint)
        {
            spawnPointIndex = 0;
        }

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Vector3 position = spawnPoints[spawnPointIndex].position + entities[entityChoice].SpawnOffset;
        
        Instantiate(entities[entityChoice].prefab, position, entities[entityChoice].prefab.transform.rotation);
        Invoke("Spawn", Random.Range(spawnTimeMin, spawnTimeMax)+entities[entityChoice].SpawnBlockTime);
    }

    void OnDrawGizmos() {
        foreach (var item in entities)
        {
            if (item.prefab)
            item.name = item.prefab.name;
        }
    }
}

