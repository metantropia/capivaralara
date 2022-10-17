using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using Unity.VisualScripting;

public class ChatBubble : MonoBehaviour
{

    private static SpriteRenderer backgroundSpriteRenderer;
    private static TextMeshPro textMeshPro;

    private void Awake() {
        backgroundSpriteRenderer = transform.Find("Background").GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
    }

    private void Start() {
       
    }

    private static void Setup(string text) {
        textMeshPro.SetText(text);
    }

    public static void GetChatBuBbleScript(string textoInserido) {
        Setup(textoInserido);
    }

    public static void SumirBubble() {
        backgroundSpriteRenderer.enabled = false;
    }

    public static void AparecerBubble() {
        backgroundSpriteRenderer.enabled = true;
    }

}
