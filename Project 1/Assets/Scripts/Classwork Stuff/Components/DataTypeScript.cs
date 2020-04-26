using UnityEngine;

// script from learn unity on data type
public class DataTypeScript : MonoBehaviour
{
    void Start()
    {
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);

        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}
