using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameManage gameManager; 
    void OnTriggerEnter ()
    {
        gameManager.LevelCompleted();
    }
}
