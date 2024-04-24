using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TrafficLightStateBaseUSA
{
    protected USATrafficLightFSM fsm;

    public TrafficLightStateBaseUSA(USATrafficLightFSM fsm)
    {
        this.fsm = fsm;
    }

    public abstract void EnterState(); 

    public abstract USATrafficLightFSM.TrafficLightState GetNextState();
}
