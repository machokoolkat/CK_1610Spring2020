using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// script from learn unity on destroy
public class DestroyBasic : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
