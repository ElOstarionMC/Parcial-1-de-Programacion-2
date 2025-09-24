using UnityEngine;

public class EnemyAiMovement : Statistics
{
    float minimalDistanceOfFollow = 20.0f;
    float accelerationMultiplier = 1.25f; // 1.25f
    float decelerationMultiplier = 1.75f; // 1.5f
    float distanceOfFollow;
    Vector2 mousePos;
    Vector2 selfPosition;
    Vector2 direction;
    Vector2 randomPos;
    Rigidbody2D rb2D;

    void Awake()
    {
        rb2D = GetComponentInChildren<Rigidbody2D>();
        SetSpeed(10.0f);
    }

    public void SetMinimalDistanceOfFollow(float newDistance)
    {
        minimalDistanceOfFollow = newDistance;
    }

    public void FollowPlayer(Transform newSelfPos)
    {
        mousePos = SMouseController.Instance.GetMousePos();
        selfPosition = newSelfPos.position;
        distanceOfFollow = Vector2.Distance(mousePos, selfPosition);

        if (distanceOfFollow <= minimalDistanceOfFollow)
        {
            direction = (mousePos - selfPosition) * (Speed * accelerationMultiplier) * Time.deltaTime;

            rb2D.MovePosition(rb2D.position + direction * (Speed * decelerationMultiplier) * Time.deltaTime);
        }
    }


    Vector2 ObjectivePos;
    public void FollowObjective(Transform newSelfPos)
    {
        ObjectivePos = ObjectiveManager.Instance.ObjectivePosition();
        // Debug.Log(ObjectivePos);
        selfPosition = newSelfPos.position;
        distanceOfFollow = Vector2.Distance(ObjectivePos, selfPosition);

        if (distanceOfFollow <= minimalDistanceOfFollow)
        {
            direction = (ObjectivePos - selfPosition) * (Speed * accelerationMultiplier) * Time.deltaTime;

            rb2D.MovePosition(rb2D.position + direction * (Speed * decelerationMultiplier) * Time.deltaTime);
        }
    }

    public void MoveOutOfScreen(Transform transform)
    {
        randomPos = ScreenController.Instance.getRandomOutScreenPosition();
        transform.position = randomPos;
    }

    public void SetAcceletationAndDeceleration(float newAccelerationMultiplier = 1, float newDecelerationMultiplier = 1)
    {
        accelerationMultiplier = newAccelerationMultiplier; // acce
        decelerationMultiplier = newDecelerationMultiplier; // dece
    }
}
