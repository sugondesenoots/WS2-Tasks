using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USATrafficLightFSM : MonoBehaviour
{
    public GameObject lightGreen;
    public GameObject lightYellow;
    public GameObject lightRed;

    public float greenDuration = 5f;
    public float yellowDuration = 2f;
    public float redDuration = 5f;

    public enum TrafficLightState
    {
        Green,
        Yellow,
        Red
    }

    private TrafficLightState currentState;
    private TrafficLightStateBaseUSA[] states;

    void Start()
    {
        currentState = TrafficLightState.Green;

        states = new TrafficLightStateBaseUSA[]
        {
            new GreenStateUSA(this),
            new YellowStateUSA(this),
            new RedStateUSA(this)
        };

        StartCoroutine(TrafficLightFSM());
    }

    IEnumerator TrafficLightFSM()
    {
        while (true)
        {
            states[(int)currentState].EnterState();

            float duration = GetDuration(currentState);

            yield return new WaitForSeconds(duration);

            currentState = states[(int)currentState].GetNextState();
        }
    }

    float GetDuration(TrafficLightState state)
    {
        switch (state)
        {
            case TrafficLightState.Green:
                return greenDuration;
            case TrafficLightState.Yellow:
                return yellowDuration;
            case TrafficLightState.Red:
                return redDuration;
            default:
                return 0f;
        }
    }

    public void SetLightColor(Color green, Color yellow, Color red)
    {
        lightGreen.GetComponent<Renderer>().material.color = green;
        lightYellow.GetComponent<Renderer>().material.color = yellow;
        lightRed.GetComponent<Renderer>().material.color = red;
    }
}

