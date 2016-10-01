using UnityEngine;
using System.Collections;

public class Control_bola : MonoBehaviour
{

    // Use this for initialization
    public Rigidbody2D RB;
    float BallSpeed = 50;
    public float Velocity_y;
    public float Velocity_x;
    public bool Jugando = false;

    void Start ()
    {
        Invoke("GoBall", 2.0f); 
	}

    // Update is called once per frame
    void OnCollision2D(Collision2D colInfo)
    {
        if(colInfo.collider.tag == "Jugador")
        {
            Velocity_y = GetComponent<Rigidbody2D>().velocity.y/2 + colInfo.collider.GetComponent<Rigidbody2D>().velocity.y/3;
            //GetComponent<AudioSource>().Play();
        }
	}

    void Update ()
    {
        float xVelocity = GetComponent<Rigidbody2D>().velocity.x;
        if(xVelocity < 18 && xVelocity > -18 && xVelocity !=0)
        {
            RB = GetComponent<Rigidbody2D>();
            if (xVelocity > 0)
            {
                RB.velocity = new Vector3(20, GetComponent<Rigidbody2D>().velocity.y);
            }
            else
            {
                RB.velocity = new Vector3(-20, GetComponent<Rigidbody2D>().velocity.y);
            }
        }
    }

    void ResetBall()
    {
        RB = GetComponent<Rigidbody2D>();

        RB.velocity = new Vector3(0, 0);
        gameObject.transform.Translate(0, 0, 0);
        gameObject.transform.position = new Vector3(0,0,0);
        
        Invoke("GoBall", 2.0f);
    }

    void GoBall()
    {
        RB = GetComponent<Rigidbody2D>();
        var randposx = Random.Range(0, 2);
        var randposy = Random.Range(0, 2);

        if (randposx <= 0.5)
        {
            if(randposy <= 0.5)
                RB.AddForce(new Vector2(BallSpeed, 10));
            else
                RB.AddForce(new Vector2(BallSpeed, -10));
        }

        else
        {
            if (randposy <= 0.5)
                RB.AddForce(new Vector2(-1 * BallSpeed, 10));
            else
                RB.AddForce(new Vector2(-1 * BallSpeed, -10));
        }

    }
}
