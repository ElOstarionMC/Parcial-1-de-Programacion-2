using UnityEngine;

public class PlayerObjective : MonoBehaviour
{
    [SerializeField] float maxDistance = 1.5f;
    [SerializeField] AudioClip testSound;
    [SerializeField] private int scoreClickOnObjective = 1;
    [SerializeField] private int scoreFailClickOnObjective = 3;
    Vector2 selfPos;
    Vector2 mousePos;
    Vector2 randomPos;
    float distanceBetweenMouseAndPlayer;
    bool isClicked;

    void Awake()
    {
        maxDistance = transform.localScale.x / 1.5f;
    }

    void Update()
    {
        mousePos = SMouseController.Instance.GetMousePos();
        selfPos = transform.position;
        distanceBetweenMouseAndPlayer = Vector2.Distance(mousePos, selfPos);

        isClicked = SMouseController.Instance.GetisClicked();

        if (distanceBetweenMouseAndPlayer <= maxDistance && isClicked)
        {
            ScoreManager.Instance.AddScore(scoreClickOnObjective);
            MoveSelfToRandomPos();
        }
        else if (distanceBetweenMouseAndPlayer >= maxDistance && isClicked)
        {
            ScoreManager.Instance.RemoveScore(scoreFailClickOnObjective);
            MoveSelfToRandomPos();
        }
        // Debug.Log("randomPos: " + Random.Range(0f,Screen.width));
        // Debug.Log("randomPosX: " + randomPos.x + "randomPosY: " + randomPos.y);
        // Debug.Log("ScoreObjective: " + scoreObjective);
        // Debug.Log("Time: " + timeCounter);
        // Debug.Log("Score: " + totalScore);
    }

    private void MoveSelfToRandomPos()
    {
        randomPos = ScreenController.Instance.getRandomInScreenPosition();
        transform.position = randomPos;
        AudioSource.PlayClipAtPoint(testSound, selfPos);
        
    }

}
