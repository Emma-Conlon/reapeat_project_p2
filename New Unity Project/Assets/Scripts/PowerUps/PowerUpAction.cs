using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpAction : MonoBehaviour
{
   
    public PowerUps power;
    public GameObject speedUp;
    public GameObject healthUp;
    public GameObject sheildp;
   
    
    // Start is called before the first frame update
    void Start()
    {
        power.GetComponent<PowerUps>();
       
        speedUp.GetComponent<Image>().enabled = false;
        sheildp.GetComponent<Image>().enabled = false;
        healthUp.GetComponent<Image>().enabled = false;

        //Fix this 

    }

    // Update is called once per frame
    void Update()
    {
        

        if (power.sheild)
        {

            speedUp.GetComponent<Image>().enabled = false;
            sheildp.GetComponent<Image>().enabled = true;
            healthUp.GetComponent<Image>().enabled = false;

        }
         if (!power.sheild)
        {
            sheildp.GetComponent<Image>().enabled = false;
        }
        if (power.speed)
        {

            speedUp.GetComponent<Image>().enabled = true;
            sheildp.GetComponent<Image>().enabled = false;
            healthUp.GetComponent<Image>().enabled = false;

        }
         if (!power.speed)
        {

            speedUp.GetComponent<Image>().enabled = false;
         

        }
        if (power.health)
        {

            speedUp.GetComponent<Image>().enabled = false;
            sheildp.GetComponent<Image>().enabled = false;
            healthUp.GetComponent<Image>().enabled = true;

        }
         if (!power.health)
        {
            healthUp.GetComponent<Image>().enabled = false;
        }
     
       }
}
