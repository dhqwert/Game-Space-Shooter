using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI; 
    public PlayerHealth playerHealth; 
    public GameObject bgMusic; 
    public GameObject gameWinUI;

    private void Start()
    {
        gameOverUI.SetActive(false); 
        gameWinUI.SetActive(false);
        playerHealth.onDead += OnGameOver; 
    }

    private void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true); 
        bgMusic.SetActive(false); 
    }

    private void OnGameWin()
    {
        gameWinUI.SetActive(true);
        bgMusic.SetActive(false);
        playerHealth.gameObject.SetActive(false);
    }

    public void ReturnToMainMenu() => SceneManager.LoadScene("MainMenu");
}