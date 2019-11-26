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

    //Vector
    private Vector2 contactPoint;
    private Vector2 temp;
    private Vector2 center;
    private Vector2 test;
    private Vector2 test2;

    private List<float> con;

    // Collider
    public EdgeCollider2D endgeGround;

    //GameObjects
    public GameObject Player;

    private void OnCollisionStay2D(Collision2D collision)
    {

        Collider2D collider = collision.collider;

        // Debug.Log("Anzahl: " + collision.contacts.Length);
        // Debug.Log(collision.contacts[0].point + " " + collision.contacts[1].point);
        contactPoint = collision.GetContact(1).point;

        // center = new Vector2(contactPoint.x + temp.x, contactPoint.y + temp.y);

        center = PlayerRB.transform.localPosition;

        // Debug.Log(Vector2 + " " + collision.contacts[0].normal);
        Debug.Log(Vector2.Angle(collision.contacts[0].normal, Vector2.right));
        if (Vector2.Angle(collision.contacts[0].normal, Vector2.right) >= 88 && Vector2.Angle(collision.contacts[0].normal, Vector2.right) <= 92)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }

        //if (center.y > contactPoint.y)
        //{
        //    grounded = true;
        //}
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

        // Debug.Log("center: " + center.y);
        // Debug.Log("contact: " + contactPoint.y);
        // Debug.Log("Transfrom: " + PlayerRB.transform.localPosition.y);

        // Debug.Log(temp);


        Vector2 moveSpeed = PlayerRB.velocity;

        if (Input.GetKey("d"))
            //Rechts
        {
            PlayerRB.AddForce(Vector3.right * Time.fixedDeltaTime * PlayerSpeed);

        }

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
        // Debug.Log(moveSpeed);
        // Debug.Log(PlayerRB.velocity);

        // Maximale Geschwindkeit festlegen.
     
    }
}
