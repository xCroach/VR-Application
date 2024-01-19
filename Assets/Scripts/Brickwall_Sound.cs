using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Brickwall_Sound : MonoBehaviour
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
        AkSoundEngine.PostEvent("Play_rocks", gameObject);
    }
    
    private void OnObjectRelease(SelectExitEventArgs args)
    {
        //AkSoundEngine.PostEvent("Play_drop", gameObject);
    }
}
