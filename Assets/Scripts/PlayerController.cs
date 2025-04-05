using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;

    bool canMove = true;
    public void ToggleMovement()
    {
        rb.linearVelocity = Vector2.zero;
        canMove = !canMove;
    }

    Vector2 movement;

    private void Start()
    {
        movement = new Vector2();
    }

    private void Update()
    {
        if (canMove)
        {
            rb.linearVelocity = movement;
        } 
    }

    public void MoveUp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            movement += Vector2.up * speed;
        } else if (context.canceled)
        {
            movement -= Vector2.up * speed;

        }
    }

    public void MoveRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            movement += Vector2.right * speed;


        }
        else if (context.canceled)
        {
            movement -= Vector2.right * speed;

        }
    }

    public void MoveDown(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            movement += Vector2.down * speed;


        }
        else if (context.canceled)
        {
            movement -= Vector2.down * speed;

        }
    }

    public void MoveLeft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            movement += Vector2.left * speed;


        }
        else if (context.canceled)
        {
            movement -= Vector2.left * speed;

        }
    }


}
