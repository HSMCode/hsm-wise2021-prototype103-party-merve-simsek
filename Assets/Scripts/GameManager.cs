using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject completeLevelUI;
    public GameObject gameOverUI;
    public GameObject Arrow;
    
    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
        Arrow.SetActive(false);
    }

    public void GameOver ()
    {
        gameOverUI.SetActive(true);
        Arrow.SetActive(false);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Gamer Over");
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
