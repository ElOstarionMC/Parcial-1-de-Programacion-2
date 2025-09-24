// using UnityEngine;
// using UnityEngine.SocialPlatforms.Impl;

// public class ScoreController : MonoBehaviour
// {
//     int actualScore = 0;
//     int scoreObjective = 0;
//     string fullScoreStr = "";

    
//     ScoreText scoreText;
    
//     // ScoreObjectiveText scoreObjectiveText;

//     public void setScore(int score, int scoreObj)
//     {
//         actualScore = score;
//         scoreObjective = scoreObj;

//         fullScoreStr = score + " / " + scoreObj;

//         scoreText.setScoreText(fullScoreStr);
//     }

//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Awake()
//     {
//         scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<ScoreText>();
//         // scoreObjectiveText = gameObject.AddComponent<ScoreObjectiveText>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
