using UnityEngine;
using System.Collections;
using System.Linq;
using System.IO;

public class Jugador1 : MonoBehaviour {

    // Use this for initialization
    
    public KeyCode arriba;
    public KeyCode abajo;
    
   // void Start () {
     //   GetComponent<Rigidbody2D>().freezeRotation = true;
       // GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
    //}
	// Update is called once per frame
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
        
    }
}
