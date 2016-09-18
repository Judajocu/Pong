using UnityEngine;
using System.Collections;
using System.Linq;
using System.IO;

public class Jugador1 : MonoBehaviour {

    // Use this for initialization
    //void Start () {

    //}
   public KeyCode arriba;
   public KeyCode abajo;
   public float velocidad = 10;
   public float builspeed;
   
	// Update is called once per frame
	void Update () {
       builspeed = GetComponent<Rigidbody2D>().velocity.y;
        if (Input.GetKey(arriba))
        {
            builspeed = velocidad; 
              
        } else if (Input.GetKey(abajo))
        {

            builspeed = velocidad * -1;
        }
        else
        {
            builspeed = 0;
        }
	}
}
