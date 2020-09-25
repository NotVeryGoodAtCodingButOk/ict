using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    private bool isChoiceLevel = false;
    public float RestartDelay = 2.114f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", RestartDelay);
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}