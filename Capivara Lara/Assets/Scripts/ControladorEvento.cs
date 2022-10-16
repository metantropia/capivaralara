using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEvento : MonoBehaviour
{
    [SerializeField]
    private Animator animator;


    void OnMouseOver() {
        this.animator.SetBool("estaIdle", false);
        ChatBubble.GetChatBuBbleScript("Clique no lixo utilizando o botão esquerdo do mouse e arraste para a lixeira correta de acordo com o material.");
        ChatBubble.AparecerBubble();
    }

    void OnMouseExit() {
        this.animator.SetBool("estaIdle", true);
        ChatBubble.GetChatBuBbleScript("");
        ChatBubble.SumirBubble();
    }
}
