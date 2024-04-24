//using UnityEngine;
//using System.Collections;

//public class StateOff : State
//{

//    public StateOff(TorchFSM fsm) : base(fsm)
//	{

//    }

//	public override void Execute()
//	{
//		Debug.Log ("In OFF state");
//		float sqrMagnitude = /* Missing code */;
//		if(sqrMagnitude < /* Missing code */)
//		{
//			fsm.ChangeState(/* Missing code */);
//		}
//	}

//	public override void Enter()
//	{
//		Debug.Log ("Enter OFF state");
//		fsm.TorchLight./* Missing code */ = 0.0f;
//	}

//	public override void Exit()
//	{
//		Debug.Log ("Exit OFF state");
//	}
//}
