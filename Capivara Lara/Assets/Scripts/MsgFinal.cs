using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts {
    public class MsgFinal : MonoBehaviour {

        private static GameObject MsgameObject;
        private static SpriteRenderer livroSpriteRenderer;
        private static SpriteRenderer albumFinalSpriteRenderer;
        private static SpriteRenderer albumInicioSpriteRenderer;
        private static SpriteRenderer sairSpriteRenderer;
        //private static Button ;

        void Update() {
            if (ProgressoObjetivo.GetLixosColetados() > 17) {
                albumFinalSpriteRenderer = transform.Find("album_final").GetComponent<SpriteRenderer>();
                albumFinalSpriteRenderer.enabled = true;

                albumInicioSpriteRenderer = transform.Find("album_inicio_fix").GetComponent<SpriteRenderer>();
                albumInicioSpriteRenderer.enabled = true;

                sairSpriteRenderer = transform.Find("Sair").GetComponent<SpriteRenderer>();
                sairSpriteRenderer.enabled = true;

                livroSpriteRenderer = transform.Find("livro_final").GetComponent<SpriteRenderer>();
                livroSpriteRenderer.enabled = true;
            }
        }
    }
}
