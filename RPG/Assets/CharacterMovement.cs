using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public float PlayerSpeed = 5f;
    // Start is called before the first frame update

    public float PlayerJumpHeight = 20f;

    public GameObject Player;

    public bool grounded;

    public Collider Ground;

    private void OnTriggerStay2D(Collider2D collision)
    {
        grounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            Player.transform.Translate(Vector3.right * Time.deltaTime * PlayerSpeed);
        }

        if (Input.GetKey("a")) 
        {
            Player.transform.Translate(Vector3.left * Time.deltaTime * PlayerSpeed);
        }

        if (Input.GetKeyDown("space") && grounded)
        {
            Player.transform.Translate(Vector3.up * Time.deltaTime * PlayerJumpHeight);
            grounded = false;
        }

    }
}
