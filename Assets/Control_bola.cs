using UnityEngine;
using System.Collections;

public class Control_bola : MonoBehaviour {

    // Use this for initialization
    public Rigidbody2D rb;
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        var randpos = Random.Range(0, 2);
        if (randpos<=0.5)
        {
            rb.AddForce(new Vector2(80,10));
        }
       else
        {
            rb.AddForce(new Vector2(-80, -10));
        }
	}

    // Update is called once per frame
    void OnCollision2D(Collision2D colInfo) {
        if(colInfo.collider.tag == "Jugador")
        {
            var velocity_y = GetComponent<Rigidbody2D>().velocity.y/2 + colInfo.collider.GetComponent<Rigidbody2D>().velocity.y/3;
        }
	}
}
