﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class results : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
   
    public GameObject playersMinuteDisplay;
    public GameObject playersSecondDisplay;
    public GameObject playersMilliDisplay;
    public GameObject oneMinuteDisplay;
    public GameObject oneSecondDisplay;
    public GameObject oneMilliDisplay;
    public GameObject twoMinuteDisplay;
    public GameObject twoSecondDisplay;
    public GameObject twoMilliDisplay;
    public bool playerwon;
    //public GameObject aiMinuteDisplay;
    //public GameObject aiSecondDisplay;
    //public GameObject aiMilliDisplay;
     private void Start()
     {
       
        first.GetComponent<Text>().text =  "1stPlace";//change 
        second.GetComponent<Text>().text = "2ndPlace";//change 
        playerwon = false;
        resultsGrid();
     }
   
    // Start is called before the first frame update
    void resultsGrid()
    {
       
        if (PositionManager.placement == 1)
            {
            playerwon = true;
           // Debug.Log("ResultsSec" + LapTimeManager.MinuteCount);
            first.GetComponent<Text>().text = "Player";//change 
            
            
           
            second.GetComponent<Text>().text = "AI";//change 
            }

            if (PositionManager.placement == 2)
            {
            playerwon = false;
                first.GetComponent<Text>().text = "AI";//change 
       
            second.GetComponent<Text>().text = "Player";//change 
            }
            // text.color = Color.yellow;
            // }

        
    }
}