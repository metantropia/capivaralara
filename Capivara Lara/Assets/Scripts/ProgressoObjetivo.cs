using System;
using UnityEngine;

namespace Assets {
    public class ProgressoObjetivo : MonoBehaviour
    { 
        private static int LixosColetados;
        private static GameObject MsgameObject;

        public static int GetLixosColetados() {
            return LixosColetados;
        }
        public static void SetLixosColetados() {
            LixosColetados++;
            
        }




    }
}
