using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuoviDestroy : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioClip getPoint;
    public AudioClip losePoint;
    private SpriteRenderer rend;

    void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.tag == "Muovi")
        {
            ScoreCounter.scoreValue += 1;
            audioSource.PlayOneShot(getPoint);
            rend.enabled = false;
            Destroy(this.gameObject, getPoint.length);
        }
        else if(collision.tag == "Bio")
        {
            LosePoint();
        }
        else if(collision.tag == "Kartonki")
        {
            LosePoint();
        }
        else if(collision.tag == "Trashcan")
        {
            LosePoint();
        }
        else if(collision.tag == "Floor")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag == "pakkausKartonki")
        {
            LosePoint();
        }
        else if(collision.tag == "pakkausKeitto")
        {
            LosePoint();
        }
        else if(collision.tag == "pakkausVaahto")
        {
            LosePoint();
        }
    }
    void LosePoint()
    {
        LifeSystem.life -= 1;
        audioSource.PlayOneShot(losePoint);
        rend.enabled = false;
        Destroy(this.gameObject, losePoint.length);
    }
}
