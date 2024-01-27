using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateTeleportRay : MonoBehaviour
{

    public GameObject leftTeleport;
    public GameObject rightTeleport;

    public InputActionProperty leftActive;
    public InputActionProperty rightActive;

    public XRRayInteractor leftRay;
    public XRRayInteractor rightRay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber,
            out bool leftValid);
        leftTeleport.SetActive(!isLeftRayHovering && leftActive.action.ReadValue<float>() > 0.1f);

        bool isRightRayHovering = rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal,
            out int rightNUmber, out bool rightValid);
        rightTeleport.SetActive(!isRightRayHovering && rightActive.action.ReadValue<float>() > 0.1f);
    }
}
