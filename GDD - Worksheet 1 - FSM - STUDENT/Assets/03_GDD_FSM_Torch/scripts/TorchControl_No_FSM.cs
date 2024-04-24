using UnityEngine;
using System.Collections;

public class TorchControl_No_FSM : MonoBehaviour
{
	public float Distance = 1.0f;

	private GameObject player;
	private Torchlight torchLight;  // The script that controls the torch animation
	private float sqrDistance;      // How close to the torch before it turns on
	private bool torchOn;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");

		sqrDistance = Distance * Distance; // Calculate Distance squared - see link below

		// Get the Torchlight *script*
		torchLight = (Torchlight)gameObject.GetComponent<Torchlight>();

		torchOn = false;           // Initialise the torch to be off
	}

	void Update()
	{
		Vector3 direction = transform.position - player.transform.position;

		// http://docs.unity3d.com/ScriptReference/Vector3-sqrMagnitude.html
		float sqrLen = direction.sqrMagnitude;

		if (!torchOn)
		{
			if (sqrLen < sqrDistance)
			{
				torchLight.IntensityLight = 1.0f;
				torchOn = true;
			}
		}
		else if (torchOn)
		{
			if (sqrLen >= sqrDistance)
			{
				torchLight.IntensityLight = 0.0f;
				torchOn = false;
			}
		}
	}
}