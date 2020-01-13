using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //ATTRIBUTES//OBJECTS

    public GameObject playerHealthbar;
    public Text dmgTxt;
    public Text chaDmgTxt;
    public Animator animator;
    public Animator enemyAnimator;
    public bool playerGotDmg;
    public bool enemyGotDmg;

    public double currrentHealthbar;
    public double maxHealthbar = 30;
    

    Enemy test = new Enemy("test", 10, 2);

    //METHODS

    private void Update()
    {
        currrentHealthbar = playerHealthbar.transform.position.x;

    }
    private void LateUpdate()
    {
        animator.SetBool("GotDmg", playerGotDmg);
        enemyAnimator.SetBool("enemyGotDmg", enemyGotDmg);
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

    public void ConvertDmgtoHealthbar(int dmg)
    {



    }



    void Start()
    {
        PlayerDmgAnim();
        EnemyDmgAnim();
    }
    

}
