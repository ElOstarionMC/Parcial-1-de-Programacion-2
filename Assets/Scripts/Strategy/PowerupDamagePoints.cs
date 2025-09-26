using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerupDamagePoints : MonoBehaviour, IPoweup
{
    Queue<Vector2> asd;
    public void Effect()
    {
        ScoreManager.Instance.RemoveScore(10);
        if (asd == null || asd.Count <= 0)
        {
            asd = ScreenController.Instance.getRandomInScreenPositionQueue();
            transform.position = asd.Dequeue();
        }
        else
        {
            transform.position = asd.Dequeue();
        }
    }
}
