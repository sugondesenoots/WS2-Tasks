using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TrafficLightStateBaseUK
{
    protected UKTrafficLightFSM fsm;

    public TrafficLightStateBaseUK(UKTrafficLightFSM fsm)
    {
        this.fsm = fsm;
    }

    public abstract void EnterState(); 

    public abstract UKTrafficLightFSM.TrafficLightState GetNextState();
}
