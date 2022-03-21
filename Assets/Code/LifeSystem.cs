using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSystem : MonoBehaviour
{
    public GameObject [] lives;
    public static int life = 3;
 
    void Update()
    {
        if(life < 1)
        {
            Destroy(lives[0].gameObject);
        }else if (life < 2)
        {
            Destroy(lives[1].gameObject);
        }else if (life < 3)
        {
            Destroy(lives[2].gameObject);
        }
    }
}
