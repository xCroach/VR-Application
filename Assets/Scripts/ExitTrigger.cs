using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        AkSoundEngine.SetState("music", "menu");
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
