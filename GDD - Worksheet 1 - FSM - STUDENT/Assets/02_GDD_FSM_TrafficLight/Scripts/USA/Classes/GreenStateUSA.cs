using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenStateUSA : TrafficLightStateBaseUSA
{
    public GreenStateUSA(USATrafficLightFSM fsm) : base(fsm) { }

    public override void EnterState()
    {
        fsm.SetLightColor(Color.black, Color.black, Color.green);
    }

    public override USATrafficLightFSM.TrafficLightState GetNextState()
    {
        return USATrafficLightFSM.TrafficLightState.Red;
    }
}
