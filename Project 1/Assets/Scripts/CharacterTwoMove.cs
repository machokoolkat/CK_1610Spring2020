using UnityEngine;

public class CharacterTwoMove : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 positionDirection;
    public float speed = 10f;
    public float gravity = -3f;
    public float jumpForce = 10f;
    void Start()
    {
        
    }
    
    void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
        if (Input.GetButtonDown("Jump"))
        {
            positionDirection.y = jumpForce;
        }

        controller.Move(positionDirection*Time.deltaTime);
        positionDirection.y += gravity;
    }
}
