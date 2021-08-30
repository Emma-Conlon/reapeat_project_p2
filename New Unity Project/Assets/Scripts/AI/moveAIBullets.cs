using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class moveAIBullets : MonoBehaviour
{
   // public PlayerHealth ph;
    //public GameObject score;
    public PlayerMove[] player;
    public int taken;
    public playerSkin skin;
   // public AIHealth carAI;
    public GameObject over;
    //public ParticleSystem explode;
    private void Start()
    {
        taken = 5;
       // explode.Stop();
        //score.GetComponent<Text>().text = "Score:" + scored.scorer.ToString();//change
         if (skin.choose == 0)
        {
            player[0].GetComponent<PlayerMove>();
        }
        if (skin.choose == 1)
        {
            player[1].GetComponent<PlayerMove>();
        }
        if (skin.choose == 2)
        {
            player[2].GetComponent<PlayerMove>();
        }
        if (skin.choose == 3)
        {
            player[3].GetComponent<PlayerMove>();
        }
        if (skin.choose == 4)
        {
            player[4].GetComponent<PlayerMove>();
        }
    }

    /// <summary>
    /// should destroy bullet if hits AI :) 
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter(Collider Col)
    {

        if (Col.tag == "Player")
        {
            
            // Debug.Log("AIScore:" + player);
            if (skin.choose == 0)
            {
                if (player[0].sheild == false)//if the sheild powerup is on no score :D 
                {
                    Debug.Log("AIHealth:" + player[0].currentHealth);
                    addScore();
                }


                damage();
                Destroy(this.gameObject);
                if (player[0].currentHealth <= 0)
                {
                    over.SetActive(true);
                    //player[4].SetActive(false);

                }
            }
            if (skin.choose == 1)
            {
                if (player[1].sheild == false)//if the sheild powerup is on no score :D 
                {
                    Debug.Log("PlayerHealth:" + player[1].currentHealth);
                    addScore();
                }


                damage();
                Destroy(this.gameObject);
                if (player[1].currentHealth <= 0)
                {
                    over.SetActive(true);
                    //player[4].SetActive(false);

                }
            }
            if (skin.choose == 2)
            {
                if (player[2].sheild == false)//if the sheild powerup is on no score :D 
                {
                    Debug.Log("AIHealth:" + player[2].currentHealth);
                    addScore();
                }


                damage();
                Destroy(this.gameObject);
                if (player[2].currentHealth <= 0)
                {
                    over.SetActive(true);
                    //player[4].SetActive(false);

                }
            }
            if (skin.choose == 3)
            {
                if (player[3].sheild == false)//if the sheild powerup is on no score :D 
                {
                    Debug.Log("AIHealth:" + player[3].currentHealth);
                    addScore();
                }


                damage();
                Destroy(this.gameObject);
                if (player[3].currentHealth <= 0)
                {
                    over.SetActive(true);
                    //player[4].SetActive(false);

                }
            }
            if (skin.choose == 4)
            {
                if (player[4].sheild == false)//if the sheild powerup is on no score :D 
                {
                    Debug.Log("AIHealth:" + player[4].currentHealth);
                    addScore();
                }


                damage();
                Destroy(this.gameObject);
                if (player[4].currentHealth <= 0)
                {
                    over.SetActive(true);
                    //player[4].SetActive(false);

                }
            }
            
        }



    }



    private void Update()
    {
       //// score.GetComponent<Text>().text = "Score:" + scored.scorer.ToString();//change 
       // if (player.currentHealth <= 0)
       // {
       //     explode.Play();

       // }
    }

    /// <summary>
    /// increases the score when the bullet hits
    /// </summary>
    public void addScore()
    {
        //scored.scorer = scored.scorer + 10;//only shows when bullet hit AI
        //score.GetComponent<Text>().text = "Score:" + scored.scorer.ToString();//change 
    }

    /// <summary>
    /// takes players Damage
    /// </summary>
    public void damage()
    {
       
        if (skin.choose == 0)
        {
            if (!player[0].sheild)
                player[0].TakeDamage(taken);
        }
        if (skin.choose == 1)
        {
            if (!player[1].sheild)
                player[1].TakeDamage(taken);
        }
        if (skin.choose == 2)
        {
            if (!player[2].sheild)
                player[2].TakeDamage(taken);
        }
        if (skin.choose == 3)
        {
            if (!player[3].sheild)
                player[3].TakeDamage(taken);
        }
        if (skin.choose == 4)
        {
            if (!player[4].sheild)
                player[4].TakeDamage(taken);
        }
    }
}
