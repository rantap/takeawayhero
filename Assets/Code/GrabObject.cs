using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(InputProcessor))]
public class GrabObject : MonoBehaviour
{
    [SerializeField]
    private Transform Detect;

    [SerializeField]
    private Transform Holder;

    [SerializeField]
    private float rayDistance;
    private Rigidbody2D rb;
    private GameObject grabbedObject;
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip losePoint;



    void OnGrab(InputAction.CallbackContext context)
    {
       
        if (context.performed == true)
        {
            RaycastHit2D grabCheck = Physics2D.Raycast(Detect.position, Vector2.right * transform.localScale, rayDistance);
            
            
            if (grabCheck.collider!=null && grabCheck.collider.tag == "Objects")
            {
                //grabbing
                if (grabbedObject == null)
                {
                    grabbedObject = grabCheck.collider.gameObject;
                    grabbedObject.transform.position = Holder.position;
                    grabbedObject.transform.parent = transform;
                    if(grabbedObject.GetComponent<Rigidbody2D>()) {
                    grabbedObject.GetComponent<Rigidbody2D>().simulated = false;
                    Destroy(grabbedObject.GetComponent<MoveObject>());
                        
                    }
                }
            }
            else if(grabbedObject != null)
            {
                grabbedObject.transform.parent = null;
                if(grabbedObject.GetComponent<Rigidbody2D>()) {
                    grabbedObject.GetComponent<Rigidbody2D>().simulated = true;
                    
                    grabbedObject = null;
                }
            }
        }
        Debug.DrawRay(Detect.position, Vector2.right * rayDistance * transform.localScale, Color.red);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(grabbedObject != null)
        {
            if(collision.tag == "Enemy")
            {
                Destroy(this.grabbedObject);
                LifeSystem.life -= 1;
                audioSource.PlayOneShot(losePoint);
                
            }
        }
    }
}