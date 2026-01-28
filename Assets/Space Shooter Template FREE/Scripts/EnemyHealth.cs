using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab;

    public int maxHealth = 3; 
    private int currentHealth; 

    void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Destroy(collision.gameObject);

        currentHealth = currentHealth - 1; 

        if (currentHealth <= 0)
        {
            Die();
        }
        else
        {
            Debug.Log("Địch trúng đạn! Máu còn: " + currentHealth);
        }
    }

    void Die() 
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f); 
        }

        Destroy(gameObject); 
    }
}