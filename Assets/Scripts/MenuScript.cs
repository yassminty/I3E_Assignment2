using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //starts game once player presses start
    }
        public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //restarts game from beginning
    }
    
    public void QuitGame()
    {
        Application.Quit(); // game will quit
        Debug.Log("Game is quitting..."); // testing is game will quit
    }
}
