using UnityEngine.SceneManagement; 

using UnityEngine;

public class GameWinManager : MonoBehaviour
{
    public void ReturnToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
