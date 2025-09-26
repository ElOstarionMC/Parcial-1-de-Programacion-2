using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class WinLoseCondition : MonoBehaviour
{

    public void WinTransition()
    {
        SceneManager.LoadScene("Main_Menu_Win");
    }

    public void LoseTransition()
    {
        SceneManager.LoadScene("Main_Menu_Lose");
    }
}
