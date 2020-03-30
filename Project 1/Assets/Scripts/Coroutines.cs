using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public int counter = 3;
    public float seconds = 1f;
    public IntData numberData;
    public UnityEvent startEvent, repeatEvent, endEvent, postEndEvent;
    private WaitForSeconds waitObj;
    IEnumerator Start()
    {
        waitObj = new WaitForSeconds(seconds);
        startEvent.Invoke();
        while (counter > 0)
        {
            numberData.value = counter;
            yield return new WaitForSeconds(seconds);
            repeatEvent.Invoke();
            counter--;
        }
        yield return waitObj;
        endEvent.Invoke();
        yield return waitObj;
        postEndEvent.Invoke();
    }
}