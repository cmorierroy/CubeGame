using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle.");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }

        if (collisionInfo.collider.tag == "Ground")
        {
            Debug.Log("We hit the ground.");
            movement.onGround = true;
        }
    }
}
