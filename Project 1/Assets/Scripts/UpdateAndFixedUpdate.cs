using UnityEngine;

// code from learn unity tutorial on Update and FixedUpdate
public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time:" + Time.deltaTime);
    }

    void Update()
    {
        Debug.Log("Update time:" + Time.deltaTime);
    }
}
