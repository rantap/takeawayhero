using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{  
    [SerializeField]
    public float objectSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -objectSpeed * Time.deltaTime, 0);
    }
}
