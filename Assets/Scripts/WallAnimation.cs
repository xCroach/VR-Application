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

    private void OnEnable()
    {
        leverGrab.selectEntered.AddListener(OnLeverTilted);
        leverGrab.selectExited.AddListener(OnLeverNotTilted);
    }
    
    private void OnDisable()
    {
        leverGrab.selectEntered.RemoveListener(OnLeverTilted);
        leverGrab.selectExited.RemoveListener(OnLeverNotTilted);
    }

    private void OnLeverTilted(SelectEnterEventArgs args)
    {
            if (leverJoint.angle <= -60)
            {
                Debug.Log("PlayAnimation");
                PlayAnimation();
            }
    }
    private void OnLeverNotTilted(SelectExitEventArgs args)
    {
        Debug.Log("OnLeverNotTilted");
    }
    
    private void PlayAnimation()
    {
        animator.SetBool("wallDown",true);
        dropzones.SetActive(true);
    }
}