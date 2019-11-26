using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //ATTRIBUTES//OBJECTS

    public GameObject txtActivator; 
    public Text dmgTxt;
    public Text chaDmgTxt;
    public Animator animator;
    public bool playerGotDmg;
    public bool enemyGotDmg;
    

    Enemy test = new Enemy("test", 10, 2);

    //METHODS


    private void LateUpdate()
    {
        animator.SetBool("GotDmg", playerGotDmg);
    }

    public void PlayerDmgAnim()
    {
        chaDmgTxt.text = "- "+ test.Getdmg().ToString();
        playerGotDmg = true;
    }

    public void EnemyDmgAnim()
    {
        dmgTxt.text = "- " + GameObject.Find("Player").GetComponent<Player>().dmg.ToString();
        enemyGotDmg = true;
    }


    void Start()
    {
        PlayerDmgAnim();
    }
    

}
