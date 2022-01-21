using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    // public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public GameObject gameOverUI;
    
         public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }

     public void GameOver ()
    {
        gameOverUI.SetActive(true);
    }
        public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Gamer Over");
            // Invoke("Restart", restartDelay);
        }
        
    }
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
}
