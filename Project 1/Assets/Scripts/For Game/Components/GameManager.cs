using UnityEngine;
using UnityEngine.SceneManagement;

// code from brackeys
public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
