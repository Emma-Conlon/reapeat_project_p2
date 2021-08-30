using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownPos : MonoBehaviour
{
    public GameObject PosirionDisplay;
 
    public AILapTrigger ailap;
    public LapTrigger[] playerlap;
    public playerSkin skin;

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
      


    }
    void OnTriggerExit(Collider other)
    {
        
        if (other.tag == "Player")
        {
            if (skin.choose == 0)
            {
                if (playerlap[0].lapNumber <= ailap.AIlapNumber)
                {
                    //up.Place = 2;

                    //PosirionDisplay.GetComponent<Text>().text = up.Place + "nd";//change 
                    if (PositionManager.placement != 2)
                    {
                        PositionManager.placement++;
                    }

                    Debug.Log(
                        PositionManager.placement);

                    if (PositionManager.placement == 2)
                    {
                        PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd";//change 
                        UpPOS.Place = 2;                                                               //text.color = Color.cyan;
                    }
                    // text.color = Color.yellow;
                }
            }
            if (skin.choose == 1)
            {
                if (playerlap[1].lapNumber <= ailap.AIlapNumber)
                {
                    //up.Place = 2;

                    //PosirionDisplay.GetComponent<Text>().text = up.Place + "nd";//change 
                    if (PositionManager.placement != 2)
                    {
                        PositionManager.placement++;
                    }

                    Debug.Log(
                        PositionManager.placement);

                    if (PositionManager.placement == 2)
                    {
                        PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd";//change 
                        UpPOS.Place = 2;                                                               //text.color = Color.cyan;
                    }
                    // text.color = Color.yellow;
                }
            }
            if (skin.choose == 2)
            {
                if (playerlap[2].lapNumber <= ailap.AIlapNumber)
                {
                    //up.Place = 2;

                    //PosirionDisplay.GetComponent<Text>().text = up.Place + "nd";//change 
                    if (PositionManager.placement != 2)
                    {
                        PositionManager.placement++;
                    }

                    Debug.Log(
                        PositionManager.placement);

                    if (PositionManager.placement == 2)
                    {
                        PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd";//change 
                        UpPOS.Place = 2;                                                               //text.color = Color.cyan;
                    }
                    // text.color = Color.yellow;
                }
            }
            if (skin.choose == 3)
            {
                if (playerlap[3].lapNumber <= ailap.AIlapNumber)
                {
                    //up.Place = 2;

                    //PosirionDisplay.GetComponent<Text>().text = up.Place + "nd";//change 
                    if (PositionManager.placement != 2)
                    {
                        PositionManager.placement++;
                    }

                    Debug.Log(
                        PositionManager.placement);

                    if (PositionManager.placement == 2)
                    {
                        PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd";//change 
                        UpPOS.Place = 2;                                                               //text.color = Color.cyan;
                    }
                    // text.color = Color.yellow;
                }
            }
            if (skin.choose == 4)
            {
                if (playerlap[4].lapNumber <= ailap.AIlapNumber)
                {
                    //up.Place = 2;

                    //PosirionDisplay.GetComponent<Text>().text = up.Place + "nd";//change 
                    if (PositionManager.placement != 2)
                    {
                        PositionManager.placement++;
                    }

                    Debug.Log(
                        PositionManager.placement);

                    if (PositionManager.placement == 2)
                    {
                        PosirionDisplay.GetComponent<Text>().text = PositionManager.placement + "nd";//change 
                        UpPOS.Place = 2;                                                               //text.color = Color.cyan;
                    }
                    // text.color = Color.yellow;
                }
            }
            //if the players laps are lower or equal to oppoments they will go first 
            

        }
    }
}
