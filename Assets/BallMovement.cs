using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    void LaunchBall()
    {
        // Launch ball in a random left or right direction
        float xDirection = Random.Range(0, 2) == 0 ? -1 : 1;
        float yDirection = Random.Range(-1f, 1f);
        Vector2 direction = new Vector2(xDirection, yDirection).normalized;

        rb.linearVelocity = direction * speed;
    }
}
