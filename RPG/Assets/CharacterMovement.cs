using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // floats
    private float PlayerJumpHeight = 5f;
    private float PlayerDownStep = 5f;
    private float PlayerSpeed = 400f;
    private float jumpWidth;

    //Rigidbodys
    public Rigidbody2D PlayerRB;

    //Boolen
    public bool isJumping;
    public bool grounded;
    public bool movingRight;
    public bool movingLeft;



    //Collider
    public Collider Ground;

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

    void FixedUpdate()
    {

        jumpWidth = PlayerRB.velocity.magnitude;

        if (Input.GetKey("d"))
            //Rechts
        {
            PlayerRB.AddForce(Vector3.right * Time.deltaTime * PlayerSpeed);
            if (movingLeft == false)
            {
                movingRight = true;

            }
            
        }

        if (Input.GetKeyUp("d"))
        {
            movingRight = false;

        }

        if (Input.GetKey("a")) 
            //Links
        {
            PlayerRB.AddForce(Vector3.left * Time.deltaTime * PlayerSpeed);

            if (movingRight == false)
            {
                movingLeft = true;

                jumpWidth = -jumpWidth;

            }

        }
        if (Input.GetKeyUp("a"))
        {
            movingLeft = false;

            jumpWidth = jumpWidth;

        }


        if (Input.GetKeyDown("space") && grounded)
        {
            /*PlayerRB.AddForce(Vector3.up * Time.deltaTime * PlayerJumpHeight, ForceMode2D.Impulse);
            grounded = false;
            */
            // isJumping = true;
            if (jumpWidth < 0)
            {
                PlayerRB.velocity = new Vector2(jumpWidth, PlayerJumpHeight);


            }
            else if (jumpWidth > 0)
            {
                PlayerRB.velocity = new Vector2(jumpWidth, PlayerJumpHeight);

            }
            else if (jumpWidth == 0)
            {
                PlayerRB.velocity = new Vector2(PlayerRB.velocity.magnitude, PlayerJumpHeight);
            }
        }

        if (Input.GetKeyDown("s"))
        {
            Player.transform.Translate(Vector3.down * Time.deltaTime * PlayerDownStep);
        }
        // Debug.Log(Vector2)

        // Jump mit dem Rigibody ist weird, besser mit ForceMode.Impulse, aber ist nicht consistent
        Debug.Log(jumpWidth);

    }
}
