using Unity.VisualScripting;
using UnityEngine;

public class PowerupPlusPoints : MonoBehaviour, IPoweup
{
    public void Effect()
    {
        ScoreManager.Instance.AddScore(2);
        transform.position = ScreenController.Instance.getRandomInScreenPosition();
        // Destroy(gameObject);
        // Statistics other = gO.GetComponent<Statistics>();

        // if (other != null)
        // {
        //     other.addHealth();
        //     Debug.Log("Healed: " + 1);
        //     Destroy(gameObject);
        // }
        // else
        // {
        //     Debug.Log("NO HEALTH " + gO.name + " No tiene statistics");
        // }
    }
}
