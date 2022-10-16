using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void PlayGame()
    {
        Console.WriteLine("Registrando");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
