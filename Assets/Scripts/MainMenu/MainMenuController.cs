using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        // Main_Level
        // Test_Room         
        SceneManager.LoadScene("Main_Level");
    }

}
