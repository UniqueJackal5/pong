using UnityEngine;

public class GoalZone : MonoBehaviour
{
    public bool isLeftGoal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            Debug.Log(isLeftGoal ? "Right Player Scores!" : "Left Player Scores!");

            // Reset ball position
            collision.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            collision.transform.position = Vector2.zero;

            // Relaunch after short delay
            collision.GetComponent<BallMovement>().Invoke("LaunchBall", 1f);
        }
    }
}
