﻿using UnityEngine;
using System.Collections;

public class Laterales : MonoBehaviour {

	void Trigger2D (Collider2D hitInfo) {

        if(hitInfo.name == "bola")
        {
            var nombre_pared = transform.name;
            Manejador_juego.Score(nombre_pared); 
        }
	
	}
}
