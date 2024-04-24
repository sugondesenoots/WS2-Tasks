using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class RedYellowState : TrafficLightStateBaseUK
{
    public RedYellowState(UKTrafficLightFSM fsm) : base(fsm) { }

    public override void EnterState()
    {
        fsm.SetLightColor(Color.red, Color.yellow, Color.black);
    }

    public override UKTrafficLightFSM.TrafficLightState GetNextState()
    {
        return UKTrafficLightFSM.TrafficLightState.Green;
    }
}
