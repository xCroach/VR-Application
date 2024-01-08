using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShootingTargets : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private HitTarget[] targets;
    
    private bool AllHit => targets.All(it=>it.hit);
    private bool alreadyTriggered = false;
    
    // Update is called once per frame
    void Update()
    {
        if (!alreadyTriggered && AllHit)
        {
            alreadyTriggered = true;
            //do some stuff
        }
    }
}
