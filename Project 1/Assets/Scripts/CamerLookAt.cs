using UnityEngine;

// script from learn unity on LookAt
public class CamerLookAt : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        transform.LookAt(target);
    }
}
