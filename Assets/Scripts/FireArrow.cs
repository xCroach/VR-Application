using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireArrow : MonoBehaviour
{
    [SerializeField] private GameObject arrow;

    [SerializeField] private Transform spawnPoint;

    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(Fire);
    }

    private void Fire(ActivateEventArgs args)
    {
        GameObject newArrow = Instantiate(arrow);
        
        Rigidbody arrowBody = newArrow.GetComponent<Rigidbody>();
        newArrow.transform.position = spawnPoint.position;
        newArrow.transform.rotation = spawnPoint.rotation;
        arrowBody.isKinematic = false;
        //newArrow.transform.rotation.Set(spawnPoint.rotation.x, spawnPoint.rotation.y + 90,spawnPoint.rotation.z,spawnPoint.rotation.w);
        arrowBody.AddForce(spawnPoint.up * speed, ForceMode.Impulse);
        AkSoundEngine.PostEvent("Play_bow", gameObject);
        Destroy(newArrow,5);
    }
}
