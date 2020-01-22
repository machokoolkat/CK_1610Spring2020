using UnityEngine;
using UnityEngine.Events;

public class NewEvent : MonoBehaviour
{
    public float floatNumber;
    public int scoreNumber;
    public UnityEvent uEvent;
    
    void Start()
    {
        uEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
