using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenState : TrafficLightStateBaseUK
{
    public GreenState(UKTrafficLightFSM fsm) : base(fsm) { }

    public override void EnterState()
    {
        fsm.SetLightColor(Color.black, Color.black, Color.green);
    }

    public override UKTrafficLightFSM.TrafficLightState GetNextState()
    {
        return UKTrafficLightFSM.TrafficLightState.Red;
    }
}
