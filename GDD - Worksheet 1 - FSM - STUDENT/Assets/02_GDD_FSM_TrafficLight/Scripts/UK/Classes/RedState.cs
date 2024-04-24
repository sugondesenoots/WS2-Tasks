using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedState : TrafficLightStateBaseUK
{
    public RedState(UKTrafficLightFSM fsm) : base(fsm) { }

    public override void EnterState()
    {
        fsm.SetLightColor(Color.red, Color.black, Color.black);
    }

    public override UKTrafficLightFSM.TrafficLightState GetNextState()
    {
        return UKTrafficLightFSM.TrafficLightState.RedYellow;
    }
}
