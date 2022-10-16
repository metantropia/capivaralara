using Assets;
using UnityEngine;


public class LataLixoMetal : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Metal") {
            Destroy(collision.gameObject);
            ProgressoObjetivo.SetLixosColetados();
        } else {
            //Evento CapivaraDialogoErro();
        }
    }

}