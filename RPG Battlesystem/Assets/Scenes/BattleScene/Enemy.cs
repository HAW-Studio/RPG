using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    //ATTRIBUTES

    public GameObject enemy;
    public GameObject messgControl;

    public string name;
    public int health;
    public int dmg;

    //CONSTRUCTOR

    public Enemy(string name,int health_,int dmg_)
    {
        health = health_;
        dmg = dmg_;
    }

    //FUNCTIONS

    public void Encounter()
    {
        enemy.SetActive(true);
        messgControl.GetComponent<Text>().text = "An " + name + " has appeared";

    }

    private void Awake()
    {
        enemy.SetActive(false);
    }

}
