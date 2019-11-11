using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public GameObject player;
    public float playerSpeed = 5f;
    public int framesMoving;
    public float rdm;
    public bool isMoving = false;
    public bool encounter = false;
    public bool loadScene = false;


    void Update()
    {

        if (!encounter)
        {

            if (isMoving)
            {
                framesMoving++;
            }

            rdm = Random.value * framesMoving;

            if (rdm * Random.value >= 100)
            {
                isMoving = false;
                encounter = true;
                loadScene = true;
                SceneManager.LoadScene("BattleScene");
            }

            if (Input.GetKey("d"))
            {
                player.transform.Translate(Vector3.right * Time.deltaTime * playerSpeed);
                isMoving = true;
            }
            if (Input.GetKey("a"))
            {
                player.transform.Translate(Vector3.left * Time.deltaTime * playerSpeed);
                isMoving = true;
            }
            if (Input.GetKeyUp("d") || Input.GetKeyUp("a"))
            {
                isMoving = false;
            }

            //Debug.Log("rdm : " + (rdm * Random.value));
        }


        
        if (encounter)
        {
            Debug.Log("ENCOUNTER !!!!");
            encounter = false;
        }
        

        Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);

    }


}
