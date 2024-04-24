using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedStateUSA : TrafficLightStateBaseUSA
{
    public RedStateUSA(USATrafficLightFSM fsm) : base(fsm) { }

    public override void EnterState()
    {
        fsm.SetLightColor(Color.red, Color.black, Color.black);
    }

    public override USATrafficLightFSM.TrafficLightState GetNextState()
    {
        return USATrafficLightFSM.TrafficLightState.Yellow;
    }
}
