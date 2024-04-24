using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UKTrafficLightFSM : MonoBehaviour
{
    public GameObject lightGreen;
    public GameObject lightYellow;
    public GameObject lightRed;

    public float redDuration = 5f;
    public float redYellowDuration = 2f;
    public float greenDuration = 5f;

    public enum TrafficLightState
    {
        Red,
        RedYellow,
        Green
    }

    private TrafficLightState currentState;
    private TrafficLightStateBaseUK[] states;

    void Start()
    {
        currentState = TrafficLightState.Red;

        states = new TrafficLightStateBaseUK[]
        {
            new RedState(this),
            new RedYellowState(this),
            new GreenState(this)
        }; 

        StartCoroutine(TrafficLightFSM());
    }

    IEnumerator TrafficLightFSM()
    {
        while (true)
        {
            states[(int)currentState].EnterState();
            float duration = GetDuration(currentState);

            float elapsedTime = 0f;
            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime * Time.timeScale;
                yield return null;
            }

            currentState = states[(int)currentState].GetNextState();
        }
    }

    float GetDuration(TrafficLightState state)
    {
        float duration = 0f;
        switch (state)
        {
            case TrafficLightState.Red:
                duration = redDuration;
                Debug.Log("Red Duration: " + duration);
                break;
            case TrafficLightState.RedYellow:
                duration = redYellowDuration;
                Debug.Log("Red-Yellow Duration: " + duration);
                break;
            case TrafficLightState.Green:
                duration = greenDuration;
                Debug.Log("Green Duration: " + duration);
                break;
            default:
                Debug.LogWarning("Unknown state: " + state);
                break;
        }
        return duration;
    }


    public void SetLightColor(Color red, Color yellow, Color green)
    {
        lightRed.GetComponent<Renderer>().material.color = red;
        lightYellow.GetComponent<Renderer>().material.color = yellow;
        lightGreen.GetComponent<Renderer>().material.color = green;
    }
}

