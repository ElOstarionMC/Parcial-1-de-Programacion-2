// using UnityEngine;

// public class ClickFollow : MonoBehaviour 
// {
//     public static ClickFollow clickFollow;
//     float speed;
//     float minimalDistanceOfFollow;
//     Vector2 mousePos;
//     Vector2 selfPosition;
//     float distanceOfFollow;
//     float rectifiedSpeed;

//     public void Awake()
//     {
//         clickFollow = this;
//     }

//     public void SetSpeed(float newSpeed)
//     {
//         speed = newSpeed;
//     }

//     public void SetMinimalDistanceOfFollow(float newDistance)
//     {
//         minimalDistanceOfFollow = newDistance;
//     }

//     public void SetPositions(Transform newSelfPos)
//     {
//         mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//         selfPosition = newSelfPos.position;
//         distanceOfFollow = Vector2.Distance(mousePos, selfPosition);
//         rectifiedSpeed = speed * Time.deltaTime;
//     }

//     public void FollowPlayer(Transform newSelfPos)
//     {
//         if (distanceOfFollow <= minimalDistanceOfFollow)
//         {
//             newSelfPos.position = Vector2.MoveTowards(selfPosition, mousePos, rectifiedSpeed);
//             // Debug.Log(selfPosition);
//         }
//     }
// }
