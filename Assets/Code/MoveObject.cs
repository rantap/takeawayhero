using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{  
    [SerializeField]
    public static float objectSpeed = 0.2f;
    
    


    void Update()
    {
        transform.Translate(0, -objectSpeed * Time.deltaTime, 0);
    }
}
