using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    public static ScoreManager Instance => instance;

    [SerializeField] private TextMeshProUGUI textScore;
    private float score;
    public float Score => score;

    private void Awake()
    {
        score = 49;
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
    }

    public void RemoveScore(float newRemovedScore)
    {
        // Debug.Log("Score Reducido en: -" + newRemovedScore);
        score -= newRemovedScore;
        textScore.text = score.ToString();
    }

    public void SetScore(float newRemovedScore)
    {
        // Debug.Log("Score Seteado en: -" + newRemovedScore);
        score -= newRemovedScore;
        textScore.text = score.ToString();
    }
}
