using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTimer : MonoBehaviour
{
    
    private float ResetTimer;
    private float TimerForSpeed = 15;
    
    

    void Start()
    {
        ResetTimer = TimerForSpeed;
    }
    void Update()
    {
        TimerForSpeed -= Time.deltaTime;
        if(TimerForSpeed < 0)
        {
            MoveObject.objectSpeed += 0.2f;
            TimerForSpeed = ResetTimer;
        }
    }
}
