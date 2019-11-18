using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    //ATTRIBUTES


    public string name = "testt";
    public int health = 20;
    public int dmg = 5;

    //CONSTRUCTOR

    public Enemy(string _name,int health_,int dmg_)
    {
        name = _name;
        health = health_;
        dmg = dmg_;
    }




}
