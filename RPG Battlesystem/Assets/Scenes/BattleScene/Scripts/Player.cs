using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject player;
    public int health = 20;
    public int dmg = 5;

    

    public void GetDmg(int dmg)
    {
        Debug.Log("Health before:" + health);
        health -= dmg;
        Debug.Log("Health after:" + health);
    }




}

