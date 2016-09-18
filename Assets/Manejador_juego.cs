using UnityEngine;
using System.Collections;

public class Manejador_juego : MonoBehaviour {

	static int puntos_jugador_1 = 0;
    
    static int puntos_jugador_2 = 0;

    public GUISkin show;

	public static void Score (string pared) {

        if(pared == "tope_derecho")
        {
            puntos_jugador_1 += 1;
        }
        else
        {
            puntos_jugador_2 += 1;
        }
    }
    void display ()
    {
        GUI.skin = show;
        GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height * 2 + 30, 100, 100), "" + puntos_jugador_1);
        GUI.Label(new Rect(Screen.width / 2 + 150, Screen.height * 2 + 30, 100, 100), "" + puntos_jugador_2);
    }
}
