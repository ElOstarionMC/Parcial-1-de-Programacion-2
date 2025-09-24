using Unity.VisualScripting;
using UnityEngine;

public class PowerupDamage : MonoBehaviour, IPoweup
{
    public void Effect()
    {
        ScoreManager.Instance.RemoveScore(5);
        Destroy(gameObject);
    }
}
