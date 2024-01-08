using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTarget : MonoBehaviour
{
    [SerializeField] private Material newMaterial;
    [SerializeField] private GameObject target;
    public bool hit;
    

    private void OnTriggerEnter(Collider other)
    {
        hit = true;
        target.GetComponent<MeshRenderer>().material = newMaterial;
    }
}
