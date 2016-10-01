using UnityEngine;
using System.Collections;
using System.Linq;
using System.IO;

public class Jugador1 : MonoBehaviour {

    // Use this for initialization
    
    public KeyCode arriba;
    public KeyCode abajo;
    

	void Update () {
        

        if (Input.GetKey(arriba))
        {
            
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 5);
            
        } else if (Input.GetKey(abajo))
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -5);
            
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
            
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
    }
}
