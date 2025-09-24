using UnityEngine;

public abstract class Statistics : MonoBehaviour
{
    // protected float health = 3f;
    protected float damageToScore = 1f;
    protected float speed = 1f;

    // public float Health => health;
    public float DamageToScore => damageToScore;
    public float Speed => speed;

    // public void takeDamage(float damageReceived)
    // {
    //     health -= damageReceived;
    //     if (health <= 0)
    //     {
    //         Destroy(gameObject);
    //     }
    // }

    // public void addHealth(float plusHealth = 1)
    // {
    //     health += plusHealth;
    // }

    public float CalculateTotalDamage(float damageMultiplier = 0.25f)
    {
        damageToScore = (int)(ScoreManager.Instance.Score * damageMultiplier);
        if (damageToScore < 1) {
            damageToScore = 1;
        }
        return damageToScore;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void AddSpeed(float newSpeed)
    {
        speed += newSpeed;
    }
}
