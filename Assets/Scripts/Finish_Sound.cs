using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Sound : MonoBehaviour
{
    private bool alreadyTriggered = false;
    [SerializeField] private GameObject exit;
    private void OnTriggerEnter(Collider other)
    {
        if (!alreadyTriggered)
        {
            AkSoundEngine.SetState("music", "finish");
            AkSoundEngine.PostEvent("Play_win", gameObject);
            exit.SetActive(true);
            alreadyTriggered = true;
        }
        
    }
}
