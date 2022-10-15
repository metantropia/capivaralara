using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropriedadesEntidade : MonoBehaviour
{
    private static string TipoLixo = "Plástico";

    public static string GetTipoLixo() {
        return TipoLixo;
    }
}
