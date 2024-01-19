using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Material newMaterial;
    [SerializeField] private Material oldMaterial;
    [SerializeField] private GameObject target;
    public bool hit;
    

    private void OnTriggerEnter(Collider other)
    {
        hit = true;
        AkSoundEngine.PostEvent("Play_hit", gameObject);
        target.GetComponent<MeshRenderer>().material = newMaterial;
    }

    private async void OnTriggerExit(Collider other)
    {
        await Task.Delay(5000);
        hit = false;
        target.GetComponent<MeshRenderer>().material = oldMaterial;
    }
}
