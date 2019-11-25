using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    //ATTRIBUTES

    public GameObject enemy;
    private string name;
    private int health;
    private int dmg;

    //CONSTRUCTOR

    public Enemy(string _name,int health_,int dmg_)
    {
        name = _name;
        health = health_;
        dmg = dmg_;
    }

    public String GetName()
    {
        return name;
    }

    public int GetHealth()
    {
        return health;
    }
    public int Getdmg()
    {
        return dmg;
    }

    public void EnemyInfo()
    {
        Debug.Log("+++ Enemy Name: " + name + " +++");
        Debug.Log("        Enemy Health: " + health);
        Debug.Log("        Enemy Dmg: " + dmg);
    }



    public void GetDmg(int dmg)
    {
        Debug.Log("Health before:" + health);
        health -= dmg;
        Debug.Log("Health after:" + health);
    }

   


}
