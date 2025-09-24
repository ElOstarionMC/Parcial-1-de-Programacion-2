// using UnityEngine;

// public class EnemyAI : MonoBehaviour
// {
//     ClickFollow clickFollow;
//     [SerializeField] float speed = 3.0f;
//     [SerializeField] float minimalDistanceOfFollow = 3.0f;

//     public void SetSpeed(float newSpeed)
//     {
//         speed = newSpeed;
//     }

//     public void SetSpeedMult(float mult)
//     {
//         speed = speed * mult;
//     }

//     void Awake()
//     {
//         clickFollow = GameObject.FindGameObjectWithTag("MainGameController").GetComponent<ClickFollow>();
//     }

//     void Start()
//     {
//         ClickFollow.clickFollow.SetSpeed(speed);
//         ClickFollow.clickFollow.SetMinimalDistanceOfFollow(minimalDistanceOfFollow);
//     }

//     // Update is called once per frame
//     void FixedUpdate()
//     {
//         ClickFollow.clickFollow.SetPositions(transform);
//         ClickFollow.clickFollow.FollowPlayer(transform);
//     }
// }
