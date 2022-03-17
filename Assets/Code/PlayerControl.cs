using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(InputProcessor))]
public class PlayerControl : MonoBehaviour
{
    //public enum ControlState
    //{
    //    GamePad
    //}

    [SerializeField]
    private float characterSpeed = 1;

    private Animator animator;

    private new SpriteRenderer renderer;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    //private ControlState controlState = ControlState.GamePad;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Character is missing an animator component!");
            Debug.Break();
        }

        renderer = GetComponent<SpriteRenderer>();
        if (renderer == null)
        {
            Debug.LogError("Character is missing an renderer component!");
            Debug.Break();
        }
    }

    private void Update()
    {
        MoveCharacter();
        UpdateAnimator();
    }

    private void UpdateAnimator()
    {

        animator.SetFloat("speed", moveInput.magnitude);
        animator.SetFloat("horizontal", moveInput.x);
        animator.SetFloat("vertical", moveInput.y);
    }

    private void MoveCharacter()
    {
        rb.velocity = new Vector2(moveInput.x * characterSpeed, moveInput.y * characterSpeed);
        if(moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 0);
        }
        else if(moveInput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 0);
        }
    }

    private void OnMove(InputAction.CallbackContext callbackContext)
    {
        moveInput = callbackContext.ReadValue<Vector2>();
    }
}