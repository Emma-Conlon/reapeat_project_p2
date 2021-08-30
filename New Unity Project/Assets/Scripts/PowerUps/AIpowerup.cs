using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Events;

public class AIpowerup : MonoBehaviour
{

    // Start is called before the first frame update
    public int random;
    public bool health;
    public bool speed;
    public bool sheild;
    public GameObject aigun;
    private bool boosting;
    public GameObject speedUp;
    public GameObject healthUp;
    public GameObject sheildp;
    public AudioSource sound;
    public GameObject forcefield;
    private float boostingtimer;

    public AIHealth ai;
    void Start()
    {
       
        boosting = false;
        sound.GetComponent<AudioSource>();
       

    }
    void OnTriggerExit(Collider other)
    {


        if (other.tag == "AI")
        {
            random = Random.Range(1, 4);
           
            Debug.Log("RANDOM " + random);

            if (random == 3)
            {
                sound.Play();
                random = 0;
                Health();
                health = true;
                speed = false;
                sheild = false;
                
               

            }
            if (random == 2)
            {
                sound.Play();
                random = 0;
                Debug.Log("AISpeed");
                health = false;
                speed = true;
                sheild = false;


            }
            if (random == 1)
            {
                sound.Play();
                
                random = 0;
                health = false;
                speed = false;
                sheild = true;
                forcefield.SetActive(true);
                Debug.Log("AISheild");
            }

        }
    }

    void Health()
    {
            ai.currentHealth += 10;
            Debug.Log("AIHealth" + ai.currentHealth);
            health = false;
         
    }
    void showHealth()
    {
        if (health)
        {
            boostingtimer += Time.deltaTime;

          

            if (boostingtimer >= 3)
            {
                boostingtimer = 0;
                health = false;
                random = 0;
                healthUp.GetComponent<Image>().enabled = false;


            }

        }
    }

    /// <summary>
    /// this allows the boost to be active for a short amount of time 
    /// </summary>
    void Speed()
    {


        if (speed)
        {
            boostingtimer += Time.deltaTime;
            aigun.SetActive(true);
            Debug.Log("AI GUN Active");
            Debug.Log(boostingtimer);

            random = 0;
            boosting = false;
            if (boostingtimer >= 5)//after 5 secinds it goes off :)
            {
                aigun.SetActive(false);
                boostingtimer = 0;
                speed = false;
                
            }
        }



    }
    void Sheild()
    {

        if (sheild)
        {
            forcefield.SetActive(true);
            ai.sheild = true;
            boostingtimer += Time.deltaTime;
           
            random = 0;
            Debug.Log(boostingtimer);

            if (boostingtimer >= 3)
            {
                forcefield.SetActive(false);

                ai.sheild = false;
                sheildp.GetComponent<Image>().enabled = false;
                boostingtimer = 0;
                sheild = false;
            }
        }

    }
    private void Update()
    {
        showHealth();
        Speed();
        Sheild();
    }
}
