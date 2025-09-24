using UnityEngine;

public class Enemy : EnemyAiMovement
{
    float acceleration = 1.35f;
    float deceleration = 1.00f;
    float actualDamageToScore = 0;
    void Start()
    {
        SetMinimalDistanceOfFollow(20f);
        SetAcceletationAndDeceleration(acceleration, deceleration);
        MoveOutOfScreen(transform);
    }

    void FixedUpdate()
    {
        actualDamageToScore = CalculateTotalDamage();
        FollowPlayer(transform);
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyTwo>() == null)
        {
            MoveOutOfScreen(transform);
            ScoreManager.Instance.RemoveScore(actualDamageToScore);
        }
    }
}
