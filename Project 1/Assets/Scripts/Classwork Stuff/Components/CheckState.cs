using UnityEngine;

// code from learn unity on Activating GameObjects
public class CheckStake : MonoBehaviour
{
    public GameObject myObject;
    
    void Start()
    {
        Debug.Log("Active Self:" + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }

}
