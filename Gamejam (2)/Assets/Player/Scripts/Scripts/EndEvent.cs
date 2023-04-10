using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndEvent : MonoBehaviour
{
    public UnityEvent end;

    public void EndSituation()
    {
        end.Invoke();
    }
}
