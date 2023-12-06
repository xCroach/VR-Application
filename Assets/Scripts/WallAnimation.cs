using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAnimation : MonoBehaviour
{

    public Animator animator;
    [SerializeField] private HingeJoint lever;
    [SerializeField] private AudioSource doorSound;
    [SerializeField] private AudioSource leverSound;

    [SerializeField] private GameObject dropzones;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //lever = GameObject.Find("LeverMiddle");
        //Debug.Log(lever.GetComponent<HingeJoint>().angle);
        
        if (lever.angle <= -40 || lever.angle >= 40)
        {
            animator.SetBool("wallDown",true);
            leverSound.Play();
            doorSound.Play();
            dropzones.SetActive(true);
        }
        else
        {
            animator.SetBool("wallDown",false);
        }
        
    }
}