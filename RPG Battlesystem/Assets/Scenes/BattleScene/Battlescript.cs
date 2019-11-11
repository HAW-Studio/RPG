using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battlescript : MonoBehaviour
{

    //ATTRIBUTES

    public GameObject player;

    public int health = 20;
    public int dmg = 5;

    //FUNCTIONS

    public void doDmg(Enemy enemy)
    {
        enemy.health -= dmg;
    }

    // OBJECTS

    Enemy test = new Enemy("test", 20, 5);



    //START

    void Start()
    {
        test.Encounter();


    }

}
