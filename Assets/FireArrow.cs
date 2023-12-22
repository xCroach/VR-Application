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
        newArrow.transform.position = spawnPoint.position;
        newArrow.transform.rotation = spawnPoint.rotation;
        //newArrow.transform.rotation.Set(spawnPoint.rotation.x, spawnPoint.rotation.y + 90,spawnPoint.rotation.z,spawnPoint.rotation.w);
        newArrow.GetComponent<Rigidbody>().velocity = spawnPoint.forward * speed;
        Destroy(newArrow,5);
    }
}
