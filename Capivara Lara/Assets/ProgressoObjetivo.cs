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
            
            if(LixosColetados == 2)
                FalaCapivara(2);
        }

        public static void FalaCapivara(int tipoFrase)
        {
            switch (tipoFrase)
            {
                case 1://Instruções
                    Console.WriteLine("Minha casa está super poluida, você poderia me ajudar a limpar?");
                    break;
                case 2://Insentivo
                    Console.WriteLine("Muito bem!");
                    break;
                case 3://Lixo Errado
                    Console.WriteLine("Vish! Errou a lixeira.");
                    break;
                default:
                    break;
            }
        }
    }
}
