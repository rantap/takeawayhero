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
   private GameObject randomSpawn;
   private GameObject spawnedObject;
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
    }
    private void Spawn()
    {
        i = Random.Range(1, 4);
        if(i == 1) {
            randomSpawn = GameObject1;
        } else if (i == 2) {
            randomSpawn = GameObject2;
        } else if (i == 3) {
            randomSpawn = GameObject3;
        }
        //TODO: Spawn object to scene!
        spawnedObject = Instantiate(randomSpawn, transform.position, transform.rotation);
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.tag == "Trashcan")
    //    {
    //        Destroy(spawnedObject);
    //        spawnedObject = null;
    //    }   
    //}
    private void resetTimer()
    {
        timer = spawnTime + Random.Range(-timerOffset, timerOffset);
    }
}