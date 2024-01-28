using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class ButtonNavigation : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject how;
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("EscapeRoom");
        AkSoundEngine.SetState("music", "background");
    }
    
    public void Continue()
    {
        AkSoundEngine.PostEvent("Play_button", gameObject);
        Time.timeScale = 1;
        menu.SetActive(false);
    }

    public void HowToPlay()
    {
        AkSoundEngine.PostEvent("Play_button", gameObject);
        menu.SetActive(false);
        how.SetActive(true);
    }

    public void QuitGame()
    {
        AkSoundEngine.PostEvent("Play_button", gameObject);
        Application.Quit();
    }

    public void Back()
    {
        AkSoundEngine.PostEvent("Play_button", gameObject);
        how.SetActive(false);
        menu.SetActive(true);
    }
}
