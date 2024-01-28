using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Transform head;
    private float spawnDistance = 1;
    
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject how;
    [SerializeField] private InputActionProperty showButton;

    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            Time.timeScale = 0;
            how.SetActive(false);
            menu.SetActive(!menu.activeSelf);
            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }
        menu.transform.LookAt(new Vector3(head.position.x,menu.transform.position.y,head.position.z));
        menu.transform.forward *= -1;

        if (menu.activeSelf == false && !how.activeSelf)
        {
            Time.timeScale = 1;
        }
    }
}
