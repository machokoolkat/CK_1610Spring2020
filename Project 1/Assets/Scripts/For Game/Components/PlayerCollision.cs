using UnityEngine;

// code from Brackeys
public class PlayerCollision : MonoBehaviour
{
    public GameCharacterMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
