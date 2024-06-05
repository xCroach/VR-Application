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
        if (!other.gameObject.CompareTag("Arrow")) return;
        hit = true;
        if (other.gameObject.TryGetComponent(out Rigidbody rigidbody))
        {
            Debug.Log(rigidbody.velocity.magnitude);
            AkSoundEngine.SetRTPCValue("speed", rigidbody.velocity.magnitude);
        }
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
