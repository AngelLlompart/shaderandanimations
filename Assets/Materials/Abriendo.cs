using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abriendo : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        animator.Play("abrir");
    }
    
    private void OnTriggerExit(Collider other)
    {
        animator.Play("cerrar");
    }
}
