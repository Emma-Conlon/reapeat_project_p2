using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHealth : MonoBehaviour
{
    public float currentHealth;
    public bool sheild;
    public float maxHealth;//AIs max Health
    //public ParticleSystem explode;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
        sheild = false;
       // explode.SetActive(false);
       // explode.Stop();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

   public void TakeDamage(int damage)
    {
        if(!sheild)
        {
            currentHealth -= damage;
        }
      
        //health.SetHealth(currentHealth);

    }
}
