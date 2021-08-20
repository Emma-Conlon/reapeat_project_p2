using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
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
    public GameObject sheildp2;
    public GameObject sheildp3;
    public AudioSource sound;
    public GameObject sheildp5;
    public GameObject sheildp4;
    public GameObject forcefield;
    private float boostingtimer;

    public PlayerHealth ph;
    void Start()
    {
        player.GetComponent<PlayerMove>();
        boosting = false;
        sound.GetComponent<AudioSource>();
        speedUp.GetComponent<Image>().enabled = false;
        sheildp.GetComponent<Image>().enabled = false;
        healthUp.GetComponent<Image>().enabled = false;

    }
    void OnTriggerExit(Collider other)
    {
      
     
            if (other.gameObject.CompareTag("Player"))
            {
            //random = Random.Range(1, 3);
            random = 1;
            Debug.Log("RANDOM " + random);

            if (random==3)
            {
                sound.Play();
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
                sound.Play();
                speedUp.GetComponent<Image>().enabled = true;
                random = 0;
                Debug.Log("Speed");
                health = false;
                speed = true;
                sheild = false;
                
               
            }
            if (random == 1)
            {
                sound.Play();
                sheildp.GetComponent<Image>().enabled = true;
                random = 0;
                health = false;
                speed = false;
                sheild = true;
                sheildp2.SetActive(true);
                sheildp4.SetActive(true);
                sheildp3.SetActive(true);
                sheildp5.SetActive(true);
                forcefield.SetActive(true);
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
                PlayerMove.motorForce = 3000;//doubles speed 
                Debug.Log(PlayerMove.motorForce);
                Debug.Log(boostingtimer);
              
                random = 0;
            boosting = false;
                if (boostingtimer >= 3)
                {
                PlayerMove.motorForce = 1000;
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
            forcefield.SetActive(true);
            sheildp2.SetActive(true);
            sheildp3.SetActive(true);
            sheildp4.SetActive(true);
            sheildp5.SetActive(true);
            boostingtimer += Time.deltaTime;
                player.sheild = true;
                random = 0;
                Debug.Log(boostingtimer);
              
                if (boostingtimer >= 3)
                {
                forcefield.SetActive(false);
                sheildp2.SetActive(false);
                sheildp3.SetActive(false);
                sheildp4.SetActive(false);
                sheildp5.SetActive(false);
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
