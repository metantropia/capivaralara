using System;
using UnityEngine;

namespace Assets {
    internal class ProgressoObjetivo {

        private static int LixosColetados;

        public static int GetLixosColetados() {
            return LixosColetados;
        }

        public static void SetLixosColetados() {
            LixosColetados++;
        }
    }
}
