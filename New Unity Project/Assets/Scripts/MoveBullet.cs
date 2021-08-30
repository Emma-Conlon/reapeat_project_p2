using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
 

/// <summary>
/// checks to see if player hit AI :) 
/// </summary>
public class MoveBullet : MonoBehaviour
{
    public GameObject ai;
    public GameObject score;
    public PlayerMove scored;
    public AIHealth carAI;
    public GameObject over;
    public ParticleSystem explode;
    private void Start()
    {
        explode.Stop();
        score.GetComponent<Text>().text = "Score:" + scored.scorer.ToString();//change 
    }
  
    /// <summary>
    /// should destroy bullet if hits AI :) 
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter(Collider Col)
    {

        if (Col.tag == "AI")
        {
            if(carAI.sheild==false)//if the sheild powerup is on no score :D 
            {
                Debug.Log("AIHealth:" + carAI.currentHealth);
                addScore();
            }
           
            score.GetComponent<Text>().text = "Score:" + scored.scorer.ToString();//change 
            damage();
            Destroy(this.gameObject);
            Debug.Log("PlayerScore:"+scored);
           if(carAI.currentHealth<=0)
            {
                over.SetActive(true);
                ai.SetActive(false);

            }
        }
       

           
    }

  

    private void Update()
    {
        score.GetComponent<Text>().text = "Score:" + scored.scorer.ToString();//change 
        if (carAI.currentHealth <= 0)
        {
            explode.Play();

        }
    }

    /// <summary>
    /// increases the score when the bullet hits
    /// </summary>
    public void addScore()
    {
        scored.scorer= scored.scorer + 10;//only shows when bullet hit AI
        score.GetComponent<Text>().text = "Score:" + scored.scorer.ToString();//change 
    }

    public void damage()
    {
        if(!carAI.sheild)
        carAI.TakeDamage(10);

    }
       
}