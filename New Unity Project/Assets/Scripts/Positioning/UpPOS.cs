using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class UpPOS : MonoBehaviour
{
    public static int Place;
    public GameObject PosirionDisplay;
    public AILapTrigger ailap;
    public LapTrigger[] playerlap;
    public playerSkin skin;
    public bool reverse;
    private void Start()
    {

    
        if (skin.choose == 0)
        {
            playerlap[0].GetComponent<LapTrigger>();
        }
        if (skin.choose == 1)
        {
            playerlap[1].GetComponent<LapTrigger>();
        }
        if (skin.choose == 2)
        {
            playerlap[2].GetComponent<LapTrigger>();
        }
        if (skin.choose == 3)
        {
            playerlap[3].GetComponent<LapTrigger>();
        }
        if (skin.choose == 4)
        {
            playerlap[4].GetComponent<LapTrigger>();
        }

        ailap.GetComponent<AILapTrigger>();
        PositionManager.placement = 2;
        PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd Place";//change 
      

    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag=="Player")
       {
            
            Update();
            //if the players laps are higher or equal to oppoments they will go first 
           
        if (skin.choose == 0)
        {
            if (playerlap[0].lapNumber >= ailap.AIlapNumber)
            {

                if (PositionManager.placement != 1)
                {
                    PositionManager.placement = 1;
                }
                if (PositionManager.placement == 1)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "st";//change 
                    Place = 1;                                               //text.color = Color.cyan;
                }
                if (PositionManager.placement == 2)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd";//change 
                    Place = 2;                                                  //text.color = Color.cyan;
                }
                //PosirionDisplay.GetComponent<Text>().text = Place + "st";//change 

                //    }

            }
           
        }
        if (skin.choose == 1)
        {
            if (playerlap[1].lapNumber >= ailap.AIlapNumber)
            {

                if (PositionManager.placement != 1)
                {
                    PositionManager.placement = 1;
                }
                if (PositionManager.placement == 1)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "st";//change 
                    Place = 1;                                               //text.color = Color.cyan;
                }
                if (PositionManager.placement == 2)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd";//change 
                    Place = 2;                                                  //text.color = Color.cyan;
                }
                //PosirionDisplay.GetComponent<Text>().text = Place + "st";//change 

                //    }

            }
        }
        if (skin.choose == 2)
        {
            if (playerlap[2].lapNumber >= ailap.AIlapNumber)
            {

                if (PositionManager.placement != 1)
                {
                    PositionManager.placement = 1;
                }
                if (PositionManager.placement == 1)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "st";//change 
                    Place = 1;                                               //text.color = Color.cyan;
                }
                if (PositionManager.placement == 2)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd";//change 
                    Place = 2;                                                  //text.color = Color.cyan;
                }
                //PosirionDisplay.GetComponent<Text>().text = Place + "st";//change 

                //    }

            }
        }
        if (skin.choose == 3)
        {
            if (playerlap[3].lapNumber >= ailap.AIlapNumber)
            {

                if (PositionManager.placement != 1)
                {
                    PositionManager.placement = 1;
                }
                if (PositionManager.placement == 1)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "st";//change 
                    Place = 1;                                               //text.color = Color.cyan;
                }
                if (PositionManager.placement == 2)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd";//change 
                    Place = 2;                                                  //text.color = Color.cyan;
                }
                //PosirionDisplay.GetComponent<Text>().text = Place + "st";//change 

                //    }

            }
        }
        if (skin.choose == 4)
        {
            if (playerlap[4].lapNumber >= ailap.AIlapNumber)
            {

                if (PositionManager.placement != 1)
                {
                    PositionManager.placement = 1;
                }
                if (PositionManager.placement == 1)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "st";//change 
                    Place = 1;                                               //text.color = Color.cyan;
                }
                if (PositionManager.placement == 2)
                {
                    PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd";//change 
                    Place = 2;                                                  //text.color = Color.cyan;
                }
                //PosirionDisplay.GetComponent<Text>().text = Place + "st";//change 

             }

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
