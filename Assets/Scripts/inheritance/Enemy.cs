using UnityEngine;

public class Enemy : EnemyAiMovement
{
    float acceleration = 1.35f;
    float deceleration = 1.00f;
    void Start()
    {
        SetMinimalDistanceOfFollow(20f);
        SetAcceletationAndDeceleration(acceleration, deceleration);
        // MoveOutOfScreen(transform);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CalculateTotalDamage();
        FollowPlayer(transform);
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        MoveOutOfScreen(transform);
    }
}
