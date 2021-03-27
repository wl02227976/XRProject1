using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MyControllerInput : MonoBehaviour
{
     public SteamVR_Input_Sources handType;

    public SteamVR_Action_Boolean sideButton_bool;
    public SteamVR_Action_Boolean upperButton_bool;

    public SteamVR_Action_Boolean lowerButton_bool;
    public SteamVR_Action_Boolean triggerButton_bool;
    public SteamVR_Action_Vector2 touchpad_vector2;
    public SteamVR_Action_Single triggerButton_vector1;


    public bool sideButtonState_bool;
    public bool upperButtonState_bool;
    public bool lowerButtonState_bool;
    public bool triggerButtonState_bool;

    public Vector2 touchpadState_vector2;
    public float triggerButtonState_vector1;


    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        sideButtonState_bool = sideButton_bool.GetStateDown(handType);
        upperButtonState_bool = upperButton_bool.GetStateDown(handType);
        lowerButtonState_bool = lowerButton_bool.GetStateDown(handType);
        triggerButtonState_bool = triggerButton_bool.GetStateDown(handType);

        touchpadState_vector2 = touchpad_vector2.GetAxis(handType);
        triggerButtonState_vector1 = triggerButton_vector1.GetAxis(handType);
      
    }
}
