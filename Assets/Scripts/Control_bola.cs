using UnityEngine;
using System.Collections;

public class Control_bola : MonoBehaviour
{

    // Use this for initialization
    public Rigidbody2D rb;
    float ballspeed = 100;
    public float velocity_y;
    public float velocity_x;

    void Start ()
    {
        Invoke("GoBall", 2.0f); 
	}

    // Update is called once per frame
    void OnCollision2D(Collision2D colInfo)
    {
        if(colInfo.collider.tag == "Jugador")
        {
            velocity_y = GetComponent<Rigidbody2D>().velocity.y/2 + colInfo.collider.GetComponent<Rigidbody2D>().velocity.y/3;
            //GetComponent<AudioSource>().Play();
        }
	}

    void Update ()
    {
        float xVelocity = GetComponent<Rigidbody2D>().velocity.x;
        if(xVelocity < 18 && xVelocity > -18 && xVelocity !=0)
        {
            rb = GetComponent<Rigidbody2D>();
            if (xVelocity > 0)
            {
                rb.velocity = new Vector3(20, GetComponent<Rigidbody2D>().velocity.y);
            }
            else
            {
                rb.velocity = new Vector3(-20, GetComponent<Rigidbody2D>().velocity.y);
            }
        }
    }

    void ResetBall()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector3(0, 0);
        gameObject.transform.Translate(0, 0, 0);
        gameObject.transform.position = new Vector3(0,0,0);

        Invoke("GoBall", 1.0f);

    }

    void GoBall()
    {
        rb = GetComponent<Rigidbody2D>();
        var randpos = Random.Range(0, 2);
        if (randpos <= 0.5)
        {
            rb.AddForce(new Vector2(ballspeed, 10));
        }
        else
        {
            rb.AddForce(new Vector2(-1 * ballspeed, -10));
        }
    }
}
