using UnityEngine;
using System.Collections;

public class TrafficLight_Coroutines : MonoBehaviour
{
	public GameObject lightGreen;
	public GameObject lightYellow;
	public GameObject lightRed;

	public float timeout = 3f;

	State currentState;

	// British sequence is: Red (STOP), then Red and Yellow (READY), then Green (GO), then back to Red
	enum State
	{
		Red, 
		RedYellow, 
		Green,
	}

	void Start()
	{
		currentState = State.Red;
	}

	void Update()
	{
		if (currentState == State.Green)
		{
			StartCoroutine(lightGo());
		}
		else if (currentState == State.RedYellow)
		{
			StartCoroutine(lightReady());
		}
		else if (currentState == State.Red)
		{
			StartCoroutine(lightStop());
		}
		else
		{
			Debug.Log("ERROR - no such state");
		}
	}

	void SetState(State state)
	{
		currentState = state;
	}

	IEnumerator lightStop()
	{ 
		setLightColor(lightRed, Color.red);
		setLightColor(lightYellow, Color.black);
		setLightColor(lightGreen, Color.black); 

		yield return new WaitForSeconds(timeout); 
	}

	IEnumerator lightReady()
	{
		setLightColor(lightRed, Color.black);
		setLightColor(lightYellow, Color.yellow);
        setLightColor(lightGreen, Color.green);

        yield return new WaitForSeconds(timeout);
    }

	IEnumerator lightGo()
	{
		setLightColor(lightRed, Color.black);
		setLightColor(lightYellow, Color.black);
		setLightColor(lightGreen, Color.green);

        yield return new WaitForSeconds(timeout);
    }

	void setLightColor(GameObject objLight, Color color)
	{
		objLight.GetComponent<Renderer>().material.color = color;
	}
}
