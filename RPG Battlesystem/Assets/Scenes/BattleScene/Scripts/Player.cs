using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Animator animator;
    public GameObject player;
    public int health = 20;
    public int dmg = 5;
    public bool gotDmg;

    

    public void GetDmg(int dmg)
    {
        Debug.Log("Health before:" + health);
        health -= dmg;
        Debug.Log("Health after:" + health);
        gotDmg = true;
    }


    private void Update()
    {
        animator.SetBool("GotDmg", gotDmg);


    }

    private void Start()
    {
        GetDmg(1);
    }



}

