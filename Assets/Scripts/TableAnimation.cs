using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableAnimation : MonoBehaviour
{

    private Animator anim;
    private Boolean isTriggered;
    public GameObject lever;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        lever = GameObject.Find("LeverMiddle");
        //Debug.Log(lever.GetComponent<HingeJoint>().angle);

        if (lever.GetComponent<HingeJoint>().angle <= -40 || lever.GetComponent<HingeJoint>().angle >= 40)
        {
            anim.SetBool("isAnimating",true);
        }
        else
        {
            anim.SetBool("isAnimating",false);
        }
        
    }
}
