using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PuzzleController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    [SerializeField] private XRSocketInteractor Piece1;
    [SerializeField] private XRSocketInteractor Piece2;
    [SerializeField] private XRSocketInteractor Piece3;
    [SerializeField] private XRSocketInteractor Piece4;

    private int piecesCorrect = 0;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        Piece1.selectEntered.AddListener(OnSocketFilled);
        Piece2.selectEntered.AddListener(OnSocketFilled);
        Piece3.selectEntered.AddListener(OnSocketFilled);
        Piece4.selectEntered.AddListener(OnSocketFilled);
        
        Piece1.selectExited.AddListener(OnSocketEmptied);
        Piece2.selectExited.AddListener(OnSocketEmptied);
        Piece3.selectExited.AddListener(OnSocketEmptied);
        Piece4.selectExited.AddListener(OnSocketEmptied);
    }

    private void OnDisable()
    {
        Piece1.selectEntered.RemoveListener(OnSocketFilled);
        Piece2.selectEntered.RemoveListener(OnSocketFilled);
        Piece3.selectEntered.RemoveListener(OnSocketFilled);
        Piece4.selectEntered.RemoveListener(OnSocketFilled);
        
        Piece1.selectExited.RemoveListener(OnSocketEmptied);
        Piece2.selectExited.RemoveListener(OnSocketEmptied);
        Piece3.selectExited.RemoveListener(OnSocketEmptied);
        Piece4.selectExited.RemoveListener(OnSocketEmptied);
        
    }

    private void OnSocketFilled(SelectEnterEventArgs args)
    {
        piecesCorrect++;
        if (piecesCorrect == 4)
        {
            PlayAnimation();
        }
    }

    private void OnSocketEmptied(SelectExitEventArgs args)
    {
        piecesCorrect--;
    }

    private void PlayAnimation()
    {
        animator.SetBool("puzzleComplete",true);
    }
}
