using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private XRGrabInteractable grab;

    private void OnEnable()
    {
        grab.selectEntered.AddListener(OnObjectGrab);
        grab.selectExited.AddListener(OnObjectRelease);
    }

    private void OnDisable()
    {
        grab.selectEntered.RemoveListener(OnObjectGrab);
        grab.selectExited.RemoveListener(OnObjectRelease);
    }

    private void OnObjectGrab(SelectEnterEventArgs args)
    {
        AkSoundEngine.PostEvent("Play_pickup", gameObject);
    }
    
    private void OnObjectRelease(SelectExitEventArgs args)
    {
        AkSoundEngine.PostEvent("Play_drop", gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        //AkSoundEngine.PostEvent("Play_drop", gameObject);
    }
}
