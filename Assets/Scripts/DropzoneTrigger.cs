using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DropzoneTrigger : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject sound;

    [SerializeField] private GameObject dropZonePineapple;
    [SerializeField] private GameObject dropZonePyramid;
    [SerializeField] private GameObject dropZoneCross;


    public bool pineapple = false;
    
    public bool pyramid = false;
    
    public bool cross = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dropZonePineapple.GetComponent<XRSocketInteractor>().interactablesSelected.Count > 0 &&
            dropZonePyramid.GetComponent<XRSocketInteractor>().interactablesSelected.Count > 0 &&
            dropZoneCross.GetComponent<XRSocketInteractor>().interactablesSelected.Count > 0)
        {
            animator.SetBool("wallDown",true);
            sound.SetActive(true);
        }
        else
        {
            animator.SetBool("wallDown",false);
            sound.SetActive(false);
        }
    }
}
