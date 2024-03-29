using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 1f;
    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        movement = direction.normalized;
        
        if (direction.x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 0);
        }
        else if (direction.x < 0)
        {
            transform.localScale = new Vector3(1, 1, 0);
        }
    }
    private void FixedUpdate() 
    {
        moveCharacter(movement);
        UpdateAnimator();
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(StopMovement());
        }
    }
    IEnumerator StopMovement() {
        moveSpeed = 0f;
        yield return new WaitForSeconds(3f);
        moveSpeed = 1f;
    }
    private void UpdateAnimator()
    {
        animator.SetFloat("speed", moveSpeed);
        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
    }
}