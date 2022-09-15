using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement stopmovement;
    
    void OnCollisionEnter (Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an Obstacle");
            
            stopmovement.enabled = false;
            FindObjectOfType<GameManage>().GameEnd();
        }
    }
}
