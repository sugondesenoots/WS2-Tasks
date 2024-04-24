using UnityEngine;
public class EnhancedTorchFSM : MonoBehaviour
{
    public enum TorchState
    {
        Off,
        Dim,
        On
    }

    public TorchState currentState = TorchState.Off;
    public float activationDistance = 5f;
    public float maxBrightness = 1f;

    public Transform bearTransform;
    private Torchlight torchLight;

    void Start()
    {
        bearTransform = GameObject.FindGameObjectWithTag("Player").transform;
        torchLight = GetComponent<Torchlight>();

        SetTorchState(TorchState.Off);
    }

    void Update()
    {
        float distanceToBear = Vector3.Distance(transform.position, bearTransform.position);

        if (distanceToBear <= activationDistance)
        {
            float brightness = 1f - Mathf.Clamp01(distanceToBear / activationDistance);
            torchLight.IntensityLight = brightness * maxBrightness; 

            if (brightness == 0)
                SetTorchState(TorchState.Off);
            else if (brightness < maxBrightness)
                SetTorchState(TorchState.Dim);
            else
                SetTorchState(TorchState.On);
        }
        else
        {
            SetTorchState(TorchState.Off);
        }
    }

    void SetTorchState(TorchState newState)
    {
        if (currentState != newState)
        {
            currentState = newState;

            switch (newState)
            {
                case TorchState.Off:
                    torchLight.enabled = false;
                    break;
                case TorchState.Dim:
                case TorchState.On:
                    torchLight.enabled = true;
                    break;
            }
        }
    }
}
