using UnityEngine;

public class GoalZone : MonoBehaviour
{
    public bool isLeftGoal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            // 🧮 Update the score
            if (isLeftGoal)
                ScoreManager.Instance.Player2Scored(); // Right player scores
            else
                ScoreManager.Instance.Player1Scored(); // Left player scores

            // Reset ball
            collision.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            collision.transform.position = Vector2.zero;

            // Relaunch after short delay
            collision.GetComponent<BallMovement>().Invoke("LaunchBall", 1f);
        }
    }
}
