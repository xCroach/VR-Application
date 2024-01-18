using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Teleport_sound : MonoBehaviour
{
    [SerializeField] private XRRayInteractor ray;

    private void OnEnable()
    {
        ray.selectExited.AddListener(OnTeleport);
    }

    private void OnTeleport(SelectExitEventArgs args)
    {
        AkSoundEngine.PostEvent("Play_teleport", gameObject);
    }
}
