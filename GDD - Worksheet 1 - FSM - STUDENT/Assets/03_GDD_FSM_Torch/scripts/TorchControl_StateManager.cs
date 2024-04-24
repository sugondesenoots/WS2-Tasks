using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchControl_StateManager : MonoBehaviour
{
    public TorchControl_BaseState currentState;
    public TorchControl_TorchOn torchOnState;
    public TorchControl_TorchOff torchOffState;

    public GameObject player;
    public Torchlight torchLight;
    void Start()
    { 
        torchOnState = new TorchControl_TorchOn(player, torchLight);
        torchOffState = new TorchControl_TorchOff(player, torchLight);

        currentState = torchOffState;
        currentState.OnEnter(this); 
    }
    void Update()
    {
        currentState.Execute(this);
    }
    public void SwitchState(TorchControl_BaseState state)
    {
        currentState = state;
        state.OnEnter(this);
    }
}
