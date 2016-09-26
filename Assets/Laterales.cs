using UnityEngine;
using System.Collections;

public class Laterales : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D hitInfo) {

        if(hitInfo.name == "bola")
        {
            var nombre_pared = transform.name;
            Manejador_juego.Score(nombre_pared);

            hitInfo.gameObject.SendMessage("ResetBall");
        }
	
	}
}
