using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            int currentScene = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(currentScene + 1);
        }
    }
}
