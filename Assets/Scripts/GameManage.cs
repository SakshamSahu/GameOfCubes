using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public GameObject gamecompletedUI;
    bool gameended = false;
    public float restartdelay= 1f;
    public void GameEnd()
    {
        if(gameended == false)
        {
            gameended = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartdelay );
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LevelCompleted()
    {
        gamecompletedUI.SetActive(true);
    }
}
