using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAnimation : MonoBehaviour
{

    public Animator animator;
    public GameObject lever;
    [SerializeField] private GameObject sound;    
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
        
        if (lever.GetComponent<HingeJoint>().angle <= -40 || lever.GetComponent<HingeJoint>().angle >= 40)
        {
            animator.SetBool("wallDown",true);
            sound.SetActive(true);
        }
        else
        {
            animator.SetBool("wallDown",false);
            sound.SetActive(false);
        }
        
    }
}