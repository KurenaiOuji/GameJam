using System;
using System.Security.Cryptography;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float movementSpeed = 5f;
    

    private Rigidbody2D rb;
    private Animator animator;
    private bool mirandoDerecha = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

  
     void Update()
    {
        
        procesarMovimiento();
       
    }

    void procesarMovimiento()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");

        if (inputMovimiento != 0f)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        Vector2 movement = new Vector2(inputMovimiento * movementSpeed, rb.velocity.y);
        rb.velocity = movement;

        gestionarOrientacion(inputMovimiento);
    }
    void gestionarOrientacion(float inputMovimiento)
    {
        if((mirandoDerecha == true && inputMovimiento < 0) || (mirandoDerecha == false && inputMovimiento > 0))
        {
            mirandoDerecha = !mirandoDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
