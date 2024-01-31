using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowPosition : MonoBehaviour
{
    [SerializeField] private Transform head;
    [SerializeField] private GameObject how;
    
    private float spawnDistance = 1;


    private void OnEnable()
    {
        how.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        how.transform.LookAt(new Vector3(head.position.x,how.transform.position.y,head.position.z));
        how.transform.forward *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
