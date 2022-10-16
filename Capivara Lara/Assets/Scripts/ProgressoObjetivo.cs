using System;
using UnityEngine;

namespace Assets {
    public class ProgressoObjetivo : MonoBehaviour
    { 
        private static int LixosColetados;
        
        public static int GetLixosColetados() {
            return LixosColetados;
        }
        public static void SetLixosColetados() {

            LixosColetados++;
            
        }

    }
}
