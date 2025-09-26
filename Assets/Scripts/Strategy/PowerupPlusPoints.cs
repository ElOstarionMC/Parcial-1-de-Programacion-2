using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerupPlusPoints : MonoBehaviour, IPoweup
{
    Queue<Vector2> asd;
    public void Effect()
    {
        ScoreManager.Instance.AddScore(2);
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
