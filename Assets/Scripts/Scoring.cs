using UnityEngine;
using UnityEngine.UI;
public class Scoring : MonoBehaviour
{
    public Transform player;
    public Text score;
    public GameObject pl;

   


    // Update is called once per frame
    void Update()
    {
        score.text = player.position.z.ToString("0");
       


    }
}
