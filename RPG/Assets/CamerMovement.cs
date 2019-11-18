using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    // floats
    public float cmrHorMove = 21;
    public float cmrVerMove = 14;

    //Cameras
    public Camera camera;

    //Transforms
    public Transform playerTrans;
    public Transform cameraTrans;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Höhe: " + camera.pixelHeight + "\nBreite: " + camera.pixelHeight);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 viewPos = camera.WorldToViewportPoint(playerTrans.position);
        // camera.WorldToWieportPoint() nimmt hier die Posisition des Transforms "Player"
        // und wandelt sie in Kordianten um, die beschreibe wo sich der Transform
        // in der Kamera aufhält.

        Debug.Log("viewPos = " + viewPos);
        if (viewPos.x >= 1.0)
            // Move Right
        {
            cameraTrans.position += Vector3.right * cmrHorMove;
        }
        if (viewPos.x <= 0)
            // Move Left
        {
            cameraTrans.position += Vector3.left * cmrVerMove;
        }
        if (viewPos.y >= 1.0)
            // Move Up
        {
            cameraTrans.position += Vector3.up * cmrVerMove;
        }
        if (viewPos.y <= 0)
        {
            cameraTrans.position += Vector3.down * cmrVerMove;
        }
    }
}
