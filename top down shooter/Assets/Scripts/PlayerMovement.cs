using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get player movement input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize();  // Keep consistent movement speed in all directions

        RotatePlayerToMouse();  // Rotate player to face the mouse
    }

    void FixedUpdate()
    {
        // Apply movement to the player
        rb.velocity = movement * moveSpeed;
    }

    void RotatePlayerToMouse()
    {
        // Get the position of the mouse in world space
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculate direction from player to mouse
        Vector2 direction = mousePos - rb.position;

        // Calculate angle to rotate player towards the mouse
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the calculated angle to the player's rotation
        rb.rotation = angle;
    }
}
