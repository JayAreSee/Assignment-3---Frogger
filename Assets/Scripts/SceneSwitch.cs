using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void GoToMenu()
    {
        Debug.Log("Loading Menu");
        SceneManager.LoadScene(0);
    }

    public void GoToMain()
    {
        Debug.Log("Loading Main");
        SceneManager.LoadScene(1);
    }

    public void GoToEnd()
    {
        Debug.Log("Loading End");
        SceneManager.LoadScene(2);
    }

    public void GoToCredits()
    {
        Debug.Log("Credits Scene");
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting the game...");
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

}