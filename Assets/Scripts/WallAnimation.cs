using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WallAnimation : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private XRGrabInteractable leverGrab;
    [SerializeField] private HingeJoint leverJoint;
    [SerializeField] private AudioSource doorSound;
    [SerializeField] private AudioSource leverSound;

    [SerializeField] private GameObject dropzones;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (leverJoint.angle <= -60)
        {
            PlayAnimation();
        }
    }
    private void PlayAnimation()
    {
        animator.SetBool("wallDown",true);
        dropzones.SetActive(true);
    }
}