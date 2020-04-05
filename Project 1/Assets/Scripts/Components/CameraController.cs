using UnityEngine;
[RequireComponent(typeof(Camera))]

public class CameraController : MonoBehaviour
{
    public Camera cameraObj;
    void Start()
    {
        cameraObj = GetComponent<Camera>();
    }
    
    void Update()
    {
        cameraObj.depth = 10f;
    }
}
