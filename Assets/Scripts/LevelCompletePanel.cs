using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompletePanel : MonoBehaviour
{
    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
