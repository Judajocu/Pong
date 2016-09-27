using UnityEngine;
using System.Collections;

public class Juego : MonoBehaviour {

    // Use this for initialization
    //void Start () {

    //}
    public Camera principal;
    public BoxCollider2D tope_max;
    public BoxCollider2D tope_min;
    public BoxCollider2D tope_izquierdo;
    public BoxCollider2D tope_derecho;

    public Transform Jugador1;
    public Transform Jugador2;
    // Update is called once per frame
    void Start () {

        //Movemos las paredes a sus puestos
        tope_max.size = new Vector2(principal.ScreenToWorldPoint(new Vector3((Screen.width * 2),0,0)).x, 1);
        tope_max.offset = new Vector2(0,(float)(principal.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y + 0.5));

        tope_min.size = new Vector2(principal.ScreenToWorldPoint(new Vector3((Screen.width * 2), 0, 0)).x, 1);
        tope_min.offset = new Vector2(0, (float)(principal.ScreenToWorldPoint(new Vector3(0, 0, 0)).y - 0.5));

        tope_izquierdo.size = new Vector2(1,principal.ScreenToWorldPoint(new Vector3(0, (Screen.height * 2), 0)).y);
        tope_izquierdo.offset = new Vector2((float)(principal.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 0.15),0);

        tope_derecho.size = new Vector2(1,principal.ScreenToWorldPoint(new Vector3(0, (Screen.height * 2), 0)).y);
        tope_derecho.offset = new Vector2((float)(principal.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x + 0.15),0);

        var posj1= Jugador1.position.x;
        var posj2 = Jugador2.position.x;

        posj1 = principal.ScreenToWorldPoint(new Vector3(75, 0, 0)).x;
        posj2 = principal.ScreenToWorldPoint(new Vector3(Screen.width - 75, 0, 0)).x;
    }
}
