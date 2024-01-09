using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TargetHitDetector : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Target[] targets;
    [SerializeField] private Animator animator;
    
    private bool AllHit => targets.All(it=>it.hit);
    private bool alreadyTriggered = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!alreadyTriggered && AllHit)
        {
            alreadyTriggered = true;
            //do some stuff
            animator.SetBool("targetsHit",true);
        }
    }
}
