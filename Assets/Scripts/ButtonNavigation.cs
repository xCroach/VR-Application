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
    }
    
    public void Continue()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
    }

    public void HowToPlay()
    {
        menu.SetActive(false);
        how.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Back()
    {
        how.SetActive(false);
        menu.SetActive(true);
    }
}
