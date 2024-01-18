using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WallAnimation : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private HingeJoint leverJoint;

    [SerializeField] private GameObject dropzones;
    
    private bool alreadyTriggered = false;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (leverJoint.angle <= -60 && !alreadyTriggered)
        {
            PlayAnimation();
            AkSoundEngine.PostEvent("Play_lever", gameObject);
            AkSoundEngine.PostEvent("Play_door", gameObject);
            alreadyTriggered = true;
        }
    }
    private void PlayAnimation()
    {
        animator.SetBool("wallDown",true);
        dropzones.SetActive(true);
    }
}