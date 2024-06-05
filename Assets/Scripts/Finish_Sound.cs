using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Sound : MonoBehaviour
{
    private bool _alreadyTriggered = false;
    [SerializeField] private GameObject exit;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        if (_alreadyTriggered) return;
        AkSoundEngine.SetState("music", "finish");
        AkSoundEngine.PostEvent("Play_win", gameObject);
        exit.SetActive(true);
        _alreadyTriggered = true;
    }
}
