using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

/// <summary>
/// Provide a pick up action for the hand.
/// </summary>
public class PickUpHand : MonoBehaviour
{
    public float distToPickup = 0.3f;
    bool handClosed = false;
    public LayerMask pickupLayer;
    public SteamVR_Input_Sources handSource = SteamVR_Input_Sources.RightHand;
    Rigidbody holdingTarget;

    void FixedUpdate()
    {
        if (SteamVR_Actions.shooter_Grab.GetState(handSource))
        {
            handClosed = true;
        }
    }
}
