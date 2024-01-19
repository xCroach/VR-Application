using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Dropzone_sound : MonoBehaviour
{
    [SerializeField] private XRSocketInteractor socket;

    private void OnEnable()
    {
        socket.selectEntered.AddListener(OnSocketFilled);
        socket.selectExited.AddListener(OnSocketEmptied);
    }

    private void OnDisable()
    {
        socket.selectEntered.RemoveListener(OnSocketFilled);
        socket.selectExited.RemoveListener(OnSocketEmptied);
    }

    private void OnSocketFilled(SelectEnterEventArgs args)
    {
        AkSoundEngine.PostEvent("Play_socket", gameObject);
    }
    
    private void OnSocketEmptied(SelectExitEventArgs args)
    {
        //AkSoundEngine.PostEvent("Play_drop", gameObject);
    }
}
