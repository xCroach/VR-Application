using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HoverBeforeFirstInteraction : MonoBehaviour
{
 
    [SerializeField] private Animator animator;
    [SerializeField] private XRGrabInteractable grab;
    [SerializeField] private Rigidbody body;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        grab.firstSelectEntered.AddListener(StopAnimation);
    }

    private void OnDisable()
    {
        grab.firstSelectEntered.RemoveListener(StopAnimation);
    }

    private void StopAnimation(SelectEnterEventArgs args)
    {
        animator.SetBool("firstGrab", true);
        Debug.Log(body.useGravity);
        body.useGravity = true;
        Debug.Log(body.useGravity);
    }
    
}
