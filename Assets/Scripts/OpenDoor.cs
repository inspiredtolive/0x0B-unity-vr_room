using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

/// <summary>
/// Provides door opening interaction.
/// </summary>
[RequireComponent( typeof( Interactable ) )]
public class OpenDoor : MonoBehaviour
{
    public Animator doorAnimator;
    private Interactable interactable;
    private bool isOpen = false;

    void Awake()
    {
        interactable = this.GetComponent<Interactable>();
    }

    private void HandHoverUpdate( Hand hand )
    {
        GrabTypes startingGrabType = hand.GetGrabStarting();
        if (interactable.attachedToHand == null && startingGrabType != GrabTypes.None && isOpen == false)
        {
            doorAnimator.SetBool("character_nearby", true);
        }
    }
}
