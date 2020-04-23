using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public manageGame manageGame;
    void OnTriggerEnter()
    {
        manageGame.CompleteLevel();
    }
}
