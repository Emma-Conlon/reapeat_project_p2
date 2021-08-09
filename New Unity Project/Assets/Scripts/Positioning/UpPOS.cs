﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpPOS : MonoBehaviour
{
    public float Place = 1;
    public GameObject PosirionDisplay;
    public AILapTrigger ailap;
    public LapTrigger playerlap;
    public bool reverse;
    private void Start()
    {

        playerlap.GetComponent<LapTrigger>();
        ailap.GetComponent<AILapTrigger>();
        Place = 1;
        PosirionDisplay.GetComponent<Text>().text = Place + "st Place";//change 
      

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            Update();
            //if the players laps are higher or equal to oppoments they will go first 
             if(playerlap.lapNumber>=ailap.AIlapNumber)
             {
            if (PositionManager.placement == 1)
            {
                PositionManager.placement=1;
            }
            else if(!reverse) {
                PositionManager.placement--;
            }
           
               if (PositionManager.placement==1)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "st";//change 
                                                                                                 //text.color = Color.cyan;
                }
                if (PositionManager.placement ==2)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd";//change 
                                                                                                 //text.color = Color.cyan;
                }
                //PosirionDisplay.GetComponent<Text>().text = Place + "st";//change 

           }
            
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            reverse = true;
        }
        else
        {
            reverse = false;
        }
    }
}