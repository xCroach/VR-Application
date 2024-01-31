using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TriggerTooltip : MonoBehaviour
{
    [SerializeField] private GameObject tooltip;
    [SerializeField] private XRGrabInteractable grab;
    private bool alreadyGrabbed = false;

    private void OnEnable()
    {
        grab.hoverEntered.AddListener(OnObjectHover);
        grab.hoverExited.AddListener(OnObjectHoverExit);
        
        grab.selectEntered.AddListener(OnObjectGrab);
    }
    
    private void OnDisable()
    {
        grab.hoverEntered.RemoveListener(OnObjectHover);
        grab.hoverExited.RemoveListener(OnObjectHoverExit);
        
        grab.selectEntered.RemoveListener(OnObjectGrab);
    }

    private void OnObjectHover(HoverEnterEventArgs args)
    {
        if (!alreadyGrabbed)
        {
            tooltip.SetActive(true);
        }
    }
    
    private void OnObjectHoverExit(HoverExitEventArgs args)
    {
        tooltip.SetActive(false);
    }

    private void OnObjectGrab(SelectEnterEventArgs args)
    {
        alreadyGrabbed = true;
    }
}
