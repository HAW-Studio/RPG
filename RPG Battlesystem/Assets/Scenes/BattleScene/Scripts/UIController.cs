using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //ATTRIBUTES//OBJECTS

    public GameObject txtActivator; 
    public Text dmgTxt;
    public AnimationClip dmgAnim;
    private Animation Anim;
   

    

    Enemy test = new Enemy("test", 10, 2);

    //METHODS

    void Awake()
    {
        Anim = GetComponent<Animation>();
        //a.Play("IdleCharacterAnim");
    }



    public void TestAnim()
    {
        Anim.Play(dmgAnim.name);
    }


    public void DmgAnim(bool enm)
    {
        if (enm)
        {
            dmgTxt.rectTransform.position.Set(200f, 38.8f, 0f);
            dmgTxt.text = GameObject.Find("Player").GetComponent<Player>().dmg.ToString();
            txtActivator.SetActive(true);
            //Anim.Play(dmgAnim.name);
            //txtActivator.SetActive(false);
        }
        if(!enm)
        {
            dmgTxt.rectTransform.position.Set(-255.7f, 20f, 0f);
            dmgTxt.text = test.Getdmg().ToString();
            txtActivator.SetActive(true);
            Anim.Play(dmgAnim.name);
            txtActivator.SetActive(false);
        }


        
    }




    void Start()
    {
        //DmgAnim(false);
    }

}
