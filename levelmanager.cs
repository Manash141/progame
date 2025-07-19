using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int currentLevel = 1;
    public int maxLevel = 35;

    public void LoadNextLevel()
    {
        currentLevel++;

        if (currentLevel > maxLevel)
        {
            Debug.Log("You completed all levels!");
            currentLevel = 1;  // Or handle game completion differently
        }

        // Load the scene by build index (assuming Level1 = index 0)
        SceneManager.LoadScene(currentLevel - 1);
    }
}
