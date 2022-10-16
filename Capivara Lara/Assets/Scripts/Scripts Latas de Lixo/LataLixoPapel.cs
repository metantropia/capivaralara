using Assets;
using UnityEngine;


public class LataLixoPapel : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Papel") {
            Destroy(collision.gameObject);
            ProgressoObjetivo.SetLixosColetados();
        } else {
            //Evento CapivaraDialogoErro();
        }
    }

}