using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Sound : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        AkSoundEngine.SetState("music", "finish");
        AkSoundEngine.PostEvent("Play_win", gameObject);
    }
}
