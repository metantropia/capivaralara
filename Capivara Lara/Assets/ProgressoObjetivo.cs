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
            
            if(LixosColetados > 4)
                FalaCapivara(2);

            if (LixosColetados > 17)
                MudaClima(true);
        }

        private static void MudaClima(bool tempoBom)
        {
            if (tempoBom)
            {

            }
        }

        private static void FalaCapivara(int tipoFrase)
        {
            switch (tipoFrase)
            {
                case 1://Instruções
                    
                    break;
                case 2://Insentivo
                    
                    break;
                case 3://Lixo Errado
                    
                    break;
                default:
                    break;
            }
        }
    }
}
