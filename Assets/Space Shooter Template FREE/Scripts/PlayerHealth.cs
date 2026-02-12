using UnityEngine;

public class PlayerHealth : Health
{
    public GameObject gameOverUI; 

    protected override void Die()
    {
        gameOverUI.SetActive(true);

        base.Die();
        
        Debug.Log("Player died");
    }
}