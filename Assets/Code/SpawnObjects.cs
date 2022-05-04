using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
   [SerializeField, Tooltip("The time after which an object is spawned")]
   private float spawnTime;
   [SerializeField, Tooltip("A random offset for the spawn timer (in seconds)")]
   private float timerOffset;
   private float timer;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject1;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject2;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject3;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject4;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject5;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject6;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject7;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject8;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject9;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject10;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject11;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject12;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject13;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject14;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject15;
   [SerializeField, Tooltip("A reference to the prefab we want to create copies from")]
   private GameObject GameObject16;

   private GameObject randomSpawn;
   private GameObject spawnedObject;
   private float spawnSpeedTimer = 75f;
   private int i;
   
   


    void Start()
    {
        timer = spawnTime + Random.Range(-timerOffset, timerOffset);
    }
    void Update()
    {
        if (timer > 0)
        {   
            timer -= Time.deltaTime;
            
            if (timer <= 0)
            {
                //Timer reached 0 (time to spawn)
                Spawn();
                resetTimer();
            }
        }
        if (spawnTime > 6f)
        {
            if(spawnSpeedTimer > 0f)
            {
                spawnSpeedTimer -= Time.deltaTime;
                
                if(spawnSpeedTimer <= 0f)
                {
                   spawnTime -= 1;
                   spawnSpeedTimer = 60f; 
                }  
            }
        }
    }
    private void Spawn()
    {
        i = Random.Range(1, 17);
        if(i == 1) {
            randomSpawn = GameObject1;
        } else if (i == 2) {
            randomSpawn = GameObject2;
        } else if (i == 3) {
            randomSpawn = GameObject3;
        } else if (i == 4) {
            randomSpawn = GameObject4;
        } else if (i == 5) {
            randomSpawn = GameObject5;
        } else if (i == 6) {
            randomSpawn = GameObject6;
        } else if (i == 7) {
            randomSpawn = GameObject7;
        } else if (i == 8) {
            randomSpawn = GameObject8;
        } else if (i == 9) {
            randomSpawn = GameObject9;
        } else if (i == 10) {
            randomSpawn = GameObject10;
        } else if (i == 11) {
            randomSpawn = GameObject11;
        } else if (i == 12) {
            randomSpawn = GameObject12;
        } else if (i == 13) {
            randomSpawn = GameObject13;
        } else if (i == 14) {
            randomSpawn = GameObject14;
        } else if (i == 15) {
            randomSpawn = GameObject15;
        } else if (i == 16) {
            randomSpawn = GameObject16;
        }
        //TODO: Spawn object to scene!
        spawnedObject = Instantiate(randomSpawn, transform.position, transform.rotation);
    }
    private void resetTimer()
    {
        timer = spawnTime + Random.Range(-timerOffset, timerOffset);
    }
}