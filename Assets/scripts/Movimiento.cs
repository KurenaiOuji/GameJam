using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float movementSpeed = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput * movementSpeed, rb.velocity.y);
        rb.velocity = movement;
    }
}
