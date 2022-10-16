using Assets;
using UnityEngine;


public class LataLixoVidro : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Vidro") {
            Destroy(collision.gameObject);
            ProgressoObjetivo.SetLixosColetados();
        } else {
            //Evento CapivaraDialogoErro();
        }
    }

}