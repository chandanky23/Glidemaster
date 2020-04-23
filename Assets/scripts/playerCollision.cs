using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<manageGame>().EndGame();
        }
    }
}
