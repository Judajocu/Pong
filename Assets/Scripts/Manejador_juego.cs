using UnityEngine;
using System.Collections;

public class Manejador_juego : MonoBehaviour
{

	static int puntos_jugador_1 = 0;
    
    static int puntos_jugador_2 = 0;

    public GUISkin show;

    public Transform LaBola;

    public bool Reinicio = false;

    public void Start()
    {
        LaBola = GameObject.FindGameObjectWithTag("bola").transform;
    }

    public void Update()
    {
        if(!Reinicio && Input.GetButtonDown("Jump"))
        {
            Reinicio = true;
            puntos_jugador_1 = 0;
            puntos_jugador_2 = 0;

        }
        Reinicio = false;
    }

	public static void Score (string pared)
    {
        if(pared.Equals("tope_derecha"))
        {
            puntos_jugador_1 += 1;
        }
        else
        {
            puntos_jugador_2 += 1;
        }
    }

    void OnGUI ()
    {
        GUI.skin = show;
        GUI.Label(new Rect(Screen.width / 2 - 100 - 9,  30, 100, 100), "" + puntos_jugador_1);
        GUI.Label(new Rect(Screen.width / 2 + 100 - 9,  30, 100, 100), "" + puntos_jugador_2);

        /*if (GUI.Button(new Rect(Screen.width / 2 - 110 / 2, 23, 110, 53), "REINICIO"))
        {
            puntos_jugador_1 = 0;
            puntos_jugador_2 = 0;

            LaBola.gameObject.SendMessage("REINICIO bola");
        }*/
    }
}
