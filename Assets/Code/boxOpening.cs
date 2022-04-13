using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxOpening : MonoBehaviour
{
    private SpriteRenderer rend;
    [SerializeField, Tooltip("Reference to the sprite")]
    private Sprite boxOpen;
    [SerializeField, Tooltip("The time after which an object is spawned")]
    private Sprite boxClosed;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = boxClosed;
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if(collision.tag == "Objects")
        {
             StartCoroutine(OpenBox());
        }
    }
    IEnumerator OpenBox() {
        rend.sprite = boxOpen;
        yield return new WaitForSeconds(1f);
        rend.sprite = boxClosed;
    }
}
