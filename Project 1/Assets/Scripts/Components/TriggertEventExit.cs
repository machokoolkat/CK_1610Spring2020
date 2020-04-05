using UnityEngine;
using UnityEngine.Events;

public class TriggertEventExit : MonoBehaviour
{
    public UnityEvent triggerEventExit;

    private void OnTriggerExit(Collider other)
    {
        triggerEventExit.Invoke();
    }
}
