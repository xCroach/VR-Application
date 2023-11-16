using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportRay : MonoBehaviour
{

    public GameObject leftTeleport;
    public GameObject rightTeleport;

    public InputActionProperty leftActive;
    public InputActionProperty rightActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftTeleport.SetActive(leftActive.action.ReadValue<float>() > 0.1f);
        rightTeleport.SetActive(rightActive.action.ReadValue<float>() > 0.1f);
    }
}
