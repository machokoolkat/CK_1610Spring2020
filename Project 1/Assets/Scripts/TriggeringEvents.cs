using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public float triggeringFloat;
    public int triggeringScore;
    public string triggeringString;
    public UnityEvent triggerFloat;
    public UnityEvent triggerScore;
    public UnityEvent triggerString;

    private void OnTriggerEnter(Collider other)
    {
        triggerFloat.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerScore.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        triggerString.Invoke();
    }
}
