using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneAnimation : MonoBehaviour
{

    public bool craneAnimated;

    private Animator anim;

    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("craneAnimated", true);
        throw new NotImplementedException();
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("craneAnimated", false);
        throw new NotImplementedException();
    }
}
