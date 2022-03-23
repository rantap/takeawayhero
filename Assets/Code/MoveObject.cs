using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{  
    [SerializeField]
    public static float objectSpeed = 0.2f;
    //int i = 2;
    // Update is called once per frame
    


    void Update()
    {
        transform.Translate(0, -objectSpeed * Time.deltaTime, 0);
        //if(ScoreCounter.scoreValue == i) 
        //{
        //    i = i + 2;
        //    objectSpeed += 0.2f;
        //}
    }
}
