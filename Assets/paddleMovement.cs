using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isPlayerOne = true;

    private Rigidbody2D rb;
    private float moveInput;
    private float paddleHeight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Calculate half-height of the paddle using its collider
        paddleHeight = GetComponent<BoxCollider2D>().bounds.extents.y;
    }

    void Update()
    {
        // Get input depending on which player
        if (isPlayerOne)
            moveInput = Input.GetAxisRaw("Vertical"); // W/S
        else
            moveInput = Input.GetAxisRaw("Vertical2"); // Custom input axes for 2nd player
    }

    void FixedUpdate()
    {
        // Move paddle
        rb.linearVelocity = new Vector2(0, moveInput * moveSpeed);

        // Dynamically calculate camera limits
        float camHeight = Camera.main.orthographicSize;
        float clampedY = Mathf.Clamp(rb.position.y, -camHeight + paddleHeight, camHeight - paddleHeight);
        rb.position = new Vector2(rb.position.x, clampedY);
    }
}
