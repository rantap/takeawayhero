using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTimer : MonoBehaviour
{
    
    private float ResetTimer;
    private float TimerForSpeed = 30;
    
    

    void Start()
    {
        ResetTimer = TimerForSpeed;
    }
    void Update()
    {
        TimerForSpeed -= Time.deltaTime;
        if(TimerForSpeed < 0)
        {
            MoveObject.objectSpeed += 0.1f;
            TimerForSpeed = ResetTimer;
        }
    }
}
