using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, startEvent, noMatchDelayedEvent;

    public void Start()
    {
        startEvent.Invoke();
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();

        if (tempObj.idObj == null)
        {
            yield break;
        }
        
        var otherID = tempObj.idObj;
        
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}
