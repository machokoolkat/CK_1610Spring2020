using UnityEngine;
using UnityEngine.Events;

public class TriggerEventStay : MonoBehaviour
{
    public UnityEvent triggerEventStay;

    private void OnTriggerStay(Collider other)
    {
        triggerEventStay.Invoke();
    }
}
