using UnityEngine;
public class TorchControl_TorchOn : TorchControl_BaseState
{
    public TorchControl_TorchOn(GameObject playerObject, Torchlight torchLightObject)
    {
        player = playerObject;
        torchLight = torchLightObject;

        sqrDistance = Distance * Distance;
        Vector3 direction = torchLightObject.transform.position - playerObject.transform.position;
        float sqrLen = direction.sqrMagnitude;
    }
    public override void Execute(TorchControl_StateManager TorchControl)
    {
        Vector3 direction = torchLight.transform.position - player.transform.position;
        float sqrLen = direction.sqrMagnitude;

        if (sqrLen < sqrDistance)
        {
            torchLight.IntensityLight = 1.0f;
        }
        else if (sqrLen >= sqrDistance)
        {
            TorchControl.SwitchState(TorchControl.torchOffState);
        }
    }
}
