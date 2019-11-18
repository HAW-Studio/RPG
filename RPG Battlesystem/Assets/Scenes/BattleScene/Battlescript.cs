using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battlescript : MonoBehaviour
{

    //ATTRIBUTES

    public GameObject messgControl;
    public GameObject player;
    public GameObject enemy;

    public Text msgText;

    public int health = 20;
    public int dmg = 5;

    //FUNCTIONS

    public void doDmg(Enemy enemy)
    {
        enemy.health -= dmg;
    }

    public void Encounter(Enemy enemy)
    {
        Debug.Log(" funktioniert es ?");

        try
        {
            messgControl.SetActive(true);
            msgText.text = "An " + enemy.name + " has appeared";
            Debug.Log("funktioniert");
        }
        catch (NullReferenceException e)
        {
            Debug.Log("nein funktioniert nicht");
        }

        Debug.Log(enemy.name + " " + enemy.health);
    }


    // OBJECTS

    Enemy test = new Enemy("test", 2000, 500);

    

    //START

    void Start()
    {
        Encounter(test);

        

    }

}
