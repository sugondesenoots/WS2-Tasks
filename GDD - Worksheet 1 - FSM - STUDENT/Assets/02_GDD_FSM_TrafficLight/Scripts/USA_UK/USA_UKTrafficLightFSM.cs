using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USA_UKTrafficLightFSM : MonoBehaviour
{
    public bool useUSAStyle = true;

    private UKTrafficLightFSM ukController;
    private USATrafficLightFSM usaController;

    void Start()
    {
        ukController = GetComponent<UKTrafficLightFSM>();
        usaController = GetComponent<USATrafficLightFSM>();

        if (useUSAStyle)
        {
            ukController.enabled = false;
            usaController.enabled = true;
        }
        else
        {
            usaController.enabled = false;
            ukController.enabled = true;
        }
    }
}
