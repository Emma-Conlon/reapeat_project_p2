using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PowerUps : MonoBehaviour
{
    // Start is called before the first frame update
    public int random;
    public PlayerMove player;
    public bool health;
    public bool speed;
    public bool sheild;
    private bool boosting;
    public GameObject speedUp;
    public GameObject healthUp;
    public GameObject sheildp;
    private float boostingtimer;

    public PlayerHealth ph;
    void Start()
    {
        player.GetComponent<PlayerMove>();
        boosting = false;
       
        speedUp.GetComponent<Image>().enabled = false;
        sheildp.GetComponent<Image>().enabled = false;
        healthUp.GetComponent<Image>().enabled = false;

    }
    void OnTriggerExit(Collider other)
    {
      
     
            if (other.gameObject.CompareTag("Player"))
            {
            random = Random.Range(1, 3);
            Debug.Log("RANDOM " + random);

            if (random==3)
            {
                random = 0;
                Debug.Log("Health");
                health = true;
                speed = false;
                healthUp.GetComponent<Image>().enabled = true;
                sheild = false;
                Health();
                Debug.Log(player.currentHealth);
            }
            if (random == 2)
            {
                speedUp.GetComponent<Image>().enabled = true;
                random = 0;
                Debug.Log("Speed");
                health = false;
                speed = true;
                sheild = false;
                
               
            }
            if (random == 1)
            {
                sheildp.GetComponent<Image>().enabled = true;
                random = 0;
                health = false;
                speed = false;
                sheild = true;
                Debug.Log("Sheild");
            }
          
        }
    }

    void Health()
    {
      
          
        




        if (health)
        {
            boostingtimer += Time.deltaTime;
            player.currentHealth += 20;
            ph.SetHealth(player.currentHealth);
            
           


            Debug.Log(boostingtimer);
            
            if (boostingtimer >= 3)
            {
                boostingtimer = 0;
                health = false;
                random = 0;
                healthUp.GetComponent<Image>().enabled = false; 
                
               
            }
         
        }
        // player.currentHealth += 10;
    
    }

    /// <summary>
    /// this allows the boost to be active for a short amount of time 
    /// </summary>
    void Speed()
    {
       
      
        if (speed)
            {
                boostingtimer += Time.deltaTime;
                player.motorForce = 3000;//doubles speed 
                Debug.Log(player.motorForce);
                Debug.Log(boostingtimer);
              
                random = 0;
            boosting = false;
                if (boostingtimer >= 3)
                {
                    player.motorForce = 1000;
                    boostingtimer = 0;
                    speed = false;
                speedUp.GetComponent<Image>().enabled = false;
                }
            }
        


    }
    void Sheild()
    {
     
            if (sheild)
            {
                boostingtimer += Time.deltaTime;
                player.sheild = true;
                random = 0;
                Debug.Log(boostingtimer);
              
                if (boostingtimer >= 3)
                {
                    player.sheild = false;
                sheildp.GetComponent<Image>().enabled = false;
                boostingtimer = 0;
                    sheild = false;
                }
            }
        
    }
    private void Update()
    {
        Health();
        Speed();
        Sheild();
    }
}
