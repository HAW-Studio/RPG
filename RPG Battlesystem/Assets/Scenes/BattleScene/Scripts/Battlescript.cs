using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battlescript : MonoBehaviour
{

    //ATTRIBUTES

    public GameObject messgControl;
    public GameObject enemy;

    public Text msgText;



    //FUNCTIONS



    public void Encounter(Enemy enemy)
    {
        Debug.Log(" funktioniert es ?");
  
        messgControl.SetActive(true);
        msgText.text = "An " + enemy.GetName() + " has appeared";
      
        Debug.Log(enemy.GetName() + " " );
    }


    // OBJECTS

    Enemy test = new Enemy("test", 10, 2);
    
    //START

    void Start()
    {
        //Encounter(test);
        //test.GetDmg(GameObject.Find("Player").GetComponent<Player>().dmg);
        //test.EnemyInfo();

        
    }

}
