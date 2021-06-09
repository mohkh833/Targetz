using UnityEngine.SceneManagement;

using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    //public static int target = 10;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            ScoreScript.scoreValue += 1;
            Die();
        }

    }
    void Die ()
    {
        Destroy(gameObject);
        
    }
}
