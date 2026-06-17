using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject tabToStart;
    public GameObject scoreText;

    void Start()
    {
        tabToStart.SetActive(true);
        gameOverPanel.SetActive(false);
        scoreText.SetActive(false);
        PauseGame();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }


    public void GameOver()
    {
        scoreText.SetActive(false);
        gameOverPanel.SetActive(true);
    }


    public void Restart() // functionality for the restart button
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit() // functionality for the quit button
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {   scoreText.SetActive(true);
        tabToStart.SetActive(false);
        Time.timeScale = 1f;
    }

    

}