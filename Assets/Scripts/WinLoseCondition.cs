using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseCondition : MonoBehaviour
{
    void Update()
    {
        if (ScoreManager.Instance.Score < 0)
        {
            ScoreManager.Instance.SetScore(0);
            SceneManager.LoadScene("Main_Menu_Lose");
        }
        if (ScoreManager.Instance.Score >= 50)
        {
            ScoreManager.Instance.SetScore(0);
            SceneManager.LoadScene("Main_Menu_Win");
        }
    }
}
