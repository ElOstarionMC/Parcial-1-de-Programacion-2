using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private IPoweup powerUp;

    void FixedUpdate()
    {
        transform.position = (Vector3)SMouseController.Instance.GetMousePos();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Statistics other = collision.gameObject.GetComponentInParent<Statistics>();

        if (other != null)
        {
            ScoreManager.Instance.RemoveScore((float)other.DamageToScore);
        }
        else
        {
            Debug.Log("NO DAMAGE " + collision.gameObject.name + " No tiene statistics");
        }
    }
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        IPoweup newPowerUp = collision.GetComponent<IPoweup>() ?? GetComponentInParent<IPoweup>();

        if (newPowerUp != null)
        {
            Debug.Log("COLLISION POWERUP");
            powerUp = newPowerUp;
            powerUp.Effect();
        }
        else
        {
            Debug.Log("ES NULO O ES: " + collision.gameObject.name);
        }
    }
}
