using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuoviDestroy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.tag == "Muovi")
        {
            ScoreCounter.scoreValue += 1;
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Bio")
        {
            LifeSystem.life -= 1;
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Kartonki")
        {
            LifeSystem.life -= 1;
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Trashcan")
        {
            LifeSystem.life -= 1;
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Floor")
        {
            Destroy(this.gameObject);
        }
    }
}
