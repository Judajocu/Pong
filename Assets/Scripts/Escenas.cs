using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Escenas : MonoBehaviour {

    public TextMesh TextoPlayer1;
    public TextMesh TextoPlayer2;
    public TextMesh TextoDescripcion;
    public TextMesh TextoEnter;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        TextoPlayer1.text = "Jugador 1";
        TextoPlayer2.text = "Jugador 2";
        TextoDescripcion.text = "Use estas teclas"+ "\n"+ "para controlar las"+ "\n"+"paletas";
        TextoEnter.text = "Pulse Enter para Jugar";

        if (Input.GetButtonDown("Submit"))
        {
            SceneManager.LoadScene("Sprites");
        }
	}
}
