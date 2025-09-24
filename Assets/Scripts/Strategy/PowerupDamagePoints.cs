using Unity.VisualScripting;
using UnityEngine;

public class PowerupDamagePoints : MonoBehaviour, IPoweup
{

    public void Effect()
    {
        ScoreManager.Instance.RemoveScore(10);
        transform.position = ScreenController.Instance.getRandomInScreenPosition();
        // Destroy(gameObject);
    }
}
