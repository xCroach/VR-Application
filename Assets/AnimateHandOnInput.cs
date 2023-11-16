using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class AnimateHandOnInput : MonoBehaviour
{

    public InputActionProperty pinchAnimation;
    public InputActionProperty grabAnimation;
    
    public Animator handAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float value = pinchAnimation.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", value);
        
        float valueGrab = grabAnimation.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", valueGrab);
    }
}
