using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    // Singleton logic
    private static ScoreManager instance;
    public static ScoreManager Instance => instance;
    [SerializeField] private TextMeshProUGUI textScore;
    private float score;
    public float Score => score;

    // Observer logic
    [SerializeField] private UnityEvent onWinScore;
    [SerializeField] private UnityEvent onLoseScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            // DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(float newAddedScore)
    {
        // Debug.Log("Score Aumentado en: +" + newAddedScore);
        score += newAddedScore;
        textScore.text = score.ToString();
        if (score >= 50)
        {
            onWinScore.Invoke();
        }
    }

    public void RemoveScore(float newRemovedScore)
    {
        // Debug.Log("Score Reducido en: -" + newRemovedScore);
        score -= newRemovedScore;
        textScore.text = score.ToString();
        if (score <= -5)
        {
            onLoseScore.Invoke();
        }
    }

    public void SetScore(float newRemovedScore)
    {
        // Debug.Log("Score Seteado en: -" + newRemovedScore);
        score -= newRemovedScore;
        textScore.text = score.ToString();
        if (score >= 50)
        {
            onWinScore.Invoke();
        }
    }
}
