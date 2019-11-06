using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public Rigidbody2D PlayerRB;

    public float PlayerSpeed = 300f;

    public float PlayerDownStep = 5f;
    // Start is called before the first frame update

    public float PlayerJumpHeight = 2500f;

    public GameObject Player;

    public bool grounded;

    public Collider Ground;

    // public Vector2 lol;
   // Vector3 center = Collider.

    private void OnCollisionStay2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;


        Vector2 contactPoint = collision.GetContact(1).point;
        Vector2 temp = collider.bounds.center;

        Vector2 center;
        center = new Vector2(contactPoint.x + temp.x, contactPoint.y + temp.y);

        if (center.x > contactPoint.x)
        {
            grounded = true;
        }
        Debug.Log(temp);
        Debug.Log("contactPoint " + contactPoint);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }

    void Start()
    {
        // lol = new Vector2(1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            PlayerRB.AddForce(Vector3.right * Time.deltaTime * PlayerSpeed);
        }

        if (Input.GetKey("a")) 
        {
            PlayerRB.AddForce(Vector3.left * Time.deltaTime * PlayerSpeed);
        }

        if (Input.GetKeyDown("space") && grounded)
        {
            PlayerRB.AddForce(Vector3.up * Time.deltaTime * PlayerJumpHeight);
            grounded = false;
        }

        if (Input.GetKey("s"))
        {
            Player.transform.Translate(Vector3.down * Time.deltaTime * PlayerDownStep);
        }
        // Debug.Log(Vector2)

        // Jump mit dem Rigibody ist weird
    }
}
