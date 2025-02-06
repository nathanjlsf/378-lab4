using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Assign the Pause Menu Canvas in the Inspector
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) // lowercase 'p' to pause game
        {
            Debug.Log("P key pressed");
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        Debug.Log("Resume button clicked");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Resume game time
        isPaused = false;
        Cursor.lockState = CursorLockMode.None; // Unlock cursor
        Cursor.visible = true; // Show cursor
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Freeze game time
        isPaused = true;
        Cursor.lockState = CursorLockMode.None; // Unlock cursor
        Cursor.visible = true; // Show cursor
    }

    public void RestartGame()
    {
        Debug.Log("Restart button clicked");
        Time.timeScale = 1f; // Ensure game time is reset
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload current scene
    }

    public void QuitGame()
    {
        Debug.Log("Quit button clicked");
        Application.Quit(); // Quits the application
    }
    
    public void EndDiveEarly()
    {
        Debug.Log("End Dive Early button clicked");
        Time.timeScale = 1f; // Reset game time
        SceneManager.LoadScene("EndScene"); // Replace "EndScene" with the exact name of your scene
    }

}
