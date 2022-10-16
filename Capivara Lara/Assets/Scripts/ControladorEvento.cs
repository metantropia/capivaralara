using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEvento : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    void OnMouseOver() {
        this.animator.SetBool("estaIdle", false);
    }

    void OnMouseExit() {
        this.animator.SetBool("estaIdle", true);
    }
}
