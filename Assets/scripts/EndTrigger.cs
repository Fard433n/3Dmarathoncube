
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gamemanger;
    private void OnTriggerEnter(Collider other)
    {
        gamemanger.Completelevel();
    }

}
