using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    private LevelManager levelManager;

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");
            levelManager.LoadNextLevel();
        }
    }
}
