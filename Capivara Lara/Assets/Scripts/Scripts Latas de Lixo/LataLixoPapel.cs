using Assets;
using UnityEngine;


public class LataLixoPapel : MonoBehaviour 
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Papel") {
            Destroy(collision.gameObject);
            ProgressoObjetivo.SetLixosColetados();
            animator.SetInteger("lixosColetados", ProgressoObjetivo.GetLixosColetados());
        } else {
            ProgressoObjetivo.FalaCapivara(3);
        }
    }

}