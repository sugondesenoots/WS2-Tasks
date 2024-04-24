using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TorchControl_BaseState
{
    protected float Distance = 1.0f;
    protected GameObject player;
    protected Torchlight torchLight;
    protected float sqrDistance;
    protected bool torchOn;

    protected TorchControl_StateManager torchControlStateManager;

    public virtual void OnEnter(TorchControl_StateManager TorchControl) { }
    public virtual void Execute(TorchControl_StateManager TorchControl) { }
}
