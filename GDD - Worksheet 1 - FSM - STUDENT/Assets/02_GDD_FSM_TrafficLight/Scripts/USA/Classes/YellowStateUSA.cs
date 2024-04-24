using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowStateUSA : TrafficLightStateBaseUSA
{
    public YellowStateUSA(USATrafficLightFSM fsm) : base(fsm) { }

    public override void EnterState()
    {
        fsm.SetLightColor(Color.black, Color.yellow, Color.black);
    }

    public override USATrafficLightFSM.TrafficLightState GetNextState()
    {
        return USATrafficLightFSM.TrafficLightState.Green;
    }
}
