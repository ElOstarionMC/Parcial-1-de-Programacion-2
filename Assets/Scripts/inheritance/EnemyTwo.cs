using UnityEngine;
using UnityEngine.Pool;

public class EnemyTwo : EnemyAiMovement
{
    float acceleration = 1.00f;
    float deceleration = 0.25f;
    float actualDamageToScore = 0;
    void Start()
    {
        SetMinimalDistanceOfFollow(20f);
        SetAcceletationAndDeceleration(acceleration, deceleration);
        // MoveOutOfScreen(transform);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        actualDamageToScore = CalculateTotalDamage();
        FollowObjective(transform);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        MoveOutOfScreen(transform);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        MoveOutOfScreen(transform);
        ScoreManager.Instance.RemoveScore(actualDamageToScore);
        
    }

}
