using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EventTriggering : MonoBehaviour
{ 
    public UnityEvent trig;

    public void DoorSituation()
    {
        trig.Invoke();
    }
}

