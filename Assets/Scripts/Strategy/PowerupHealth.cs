using Unity.VisualScripting;
using UnityEngine;

public class PowerupHealth : MonoBehaviour, IPoweup
{
    public void Effect()
    {
        ScoreManager.Instance.AddScore(5);
        Destroy(gameObject);
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
