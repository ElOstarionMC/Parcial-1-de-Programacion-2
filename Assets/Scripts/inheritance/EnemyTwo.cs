using UnityEngine;

public class EnemyTwo : EnemyAiMovement
{
    float acceleration = 1.00f;
    float deceleration = 0.25f;
    float actualDamageToScore = 0;
    void Start()
    {
        SetMinimalDistanceOfFollow(40f);
        SetAcceletationAndDeceleration(acceleration, deceleration);
        MoveOutOfScreen(transform);
    }

    void FixedUpdate()
    {
        actualDamageToScore = CalculateTotalDamage();
        FollowObjective(transform);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>() == null)
        {
            MoveOutOfScreen(transform);
            ScoreManager.Instance.RemoveScore(actualDamageToScore);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        MoveOutOfScreen(transform);
        ScoreManager.Instance.RemoveScore(actualDamageToScore);        
    }

}
