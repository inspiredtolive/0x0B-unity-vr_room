using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

/// <summary>
/// Provides turning on projector interaction.
/// </summary>
[RequireComponent( typeof( Interactable ) )]
public class TurnOnProjector : MonoBehaviour
{
    public GameObject particles;
    private Interactable interactable;
    private bool isOn = false;

    void Awake()
    {
        interactable = this.GetComponent<Interactable>();
    }

    private void HandHoverUpdate( Hand hand )
    {
        GrabTypes startingGrabType = hand.GetGrabStarting();
        if (interactable.attachedToHand == null && startingGrabType != GrabTypes.None && isOn == false)
        {
            particles.SetActive(true);
        }
    }
}
