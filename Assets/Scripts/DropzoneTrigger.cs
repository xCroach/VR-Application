using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DropzoneTrigger : MonoBehaviour
{
    [SerializeField] private Animator animator;

    [SerializeField] private XRSocketInteractor dropZonePineapple;
    [SerializeField] private XRSocketInteractor dropZonePyramid;
    [SerializeField] private XRSocketInteractor dropZoneCross;

    private int socketsFilled = 0;
    private bool alreadyTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        dropZonePineapple.selectEntered.AddListener(OnSocketFilled);
        dropZonePyramid.selectEntered.AddListener(OnSocketFilled);
        dropZoneCross.selectEntered.AddListener(OnSocketFilled);
        
        dropZonePineapple.selectExited.AddListener(OnSocketEmptied);
        dropZonePyramid.selectExited.AddListener(OnSocketEmptied);
        dropZoneCross.selectExited.AddListener(OnSocketEmptied);
    }
    private void OnDisable()
    {
        dropZonePineapple.selectEntered.RemoveListener(OnSocketFilled);
        dropZonePyramid.selectEntered.RemoveListener(OnSocketFilled);
        dropZoneCross.selectEntered.RemoveListener(OnSocketFilled);
        
        dropZonePineapple.selectExited.RemoveListener(OnSocketEmptied);
        dropZonePyramid.selectExited.RemoveListener(OnSocketEmptied);
        dropZoneCross.selectExited.RemoveListener(OnSocketEmptied);
    }
    private async void OnSocketFilled(SelectEnterEventArgs args)
    {
        socketsFilled++;
        if (socketsFilled == 3 && !alreadyTriggered)
        {
            AkSoundEngine.PostEvent("Play_success", gameObject);
            await Task.Delay(750);
            PlayAnimation();
            alreadyTriggered = true;
        }
    }
    private void OnSocketEmptied(SelectExitEventArgs args)
    {
        socketsFilled--;
    }
    private void PlayAnimation()
    {
        animator.SetBool("wallDown",true);
        AkSoundEngine.PostEvent("Play_door", gameObject);
    }
}
