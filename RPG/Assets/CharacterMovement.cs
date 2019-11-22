using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // floats
    private float PlayerJumpHeight = 5f;
    private float PlayerDownStep = 5f;
    private float PlayerSpeed = 400f;
    private float moveSpeed;
    private float tempMoveSpeed;

    //Rigidbodys
    public Rigidbody2D PlayerRB;

    //Boolen
    public bool isJumping;
    public bool grounded;
    public bool movingRight;
    public bool movingLeft;
    public bool eingabe;



    //Collider
    // public Collider Ground;
    public EdgeCollider2D endgeGround;

    //GameObjects
    public GameObject Player;

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
        //Debug.Log(temp);
        //Debug.Log("contactPoint " + contactPoint);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }

    void Start()
    {

    }

    void FixedUpdate()
    {
        Vector2 moveSpeed = PlayerRB.velocity;

        if (Input.GetKey("d"))
            //Rechts
        {
            PlayerRB.AddForce(Vector3.right * Time.fixedDeltaTime * PlayerSpeed);

        }
        // Die Geschwindigkeit des Characters darf nur dann ins Negative gewechselt werden, wenn die Geschwindigkeit wieder
        // einmal Runter gegangen ist.
        if (Input.GetKey("a"))
        //Links
        {
            PlayerRB.AddForce(Vector3.left * Time.fixedDeltaTime * PlayerSpeed);
        }


        if (Input.GetKeyDown("space") && grounded)
        {
            PlayerRB.velocity = new Vector2(moveSpeed.x, PlayerJumpHeight);

        }

        if (Input.GetKeyDown("s"))
        {
            Player.transform.Translate(Vector3.down * Time.fixedDeltaTime * PlayerDownStep);
        }
        // Debug.Log(Vector2)
        Debug.Log(moveSpeed);
        Debug.Log(PlayerRB.velocity);

        // Maximale Geschwindkeit festlegen.

    }
}
