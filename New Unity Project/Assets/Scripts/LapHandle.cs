using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapHandle : MonoBehaviour
{
    public float checkpointamt;
    public float index;
    public LapTrigger lap;
    public AILapTrigger aiLap;
    public GameObject lapNum;
    public GameObject over;
    public GameObject info;
    public GameObject pl;
    public GameObject MinuteDisplay;
    public results timer;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

  
    private void Start()
    {
        timer.GetComponent<results>();
        checkpointamt = 12;
        lap.GetComponent<LapTrigger>();
        aiLap.GetComponent<AILapTrigger>();
        lapNum.GetComponent<Text>().text = "Lap" + lap.lapNumber + "/3";//change 

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            ///checks to see all checkpoints have been passed 
            if (lap.CheckpointIndex == checkpointamt&& lap.lapNumber<=3)
            {
                lap.CheckpointIndex = 0;
                lap.lapNumber++;
                Debug.Log(lap.lapNumber);
                lapNum.GetComponent<Text>().text = "Lap" + lap.lapNumber + "/3";//change 
                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                    if(PositionManager.placement == 1)
                    {
                        timer.oneSecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";

                    }
                    if(PositionManager.placement == 2)
                    {
                        timer.twoSecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                    }
                }
                else
                {
                    SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
                    if (PositionManager.placement == 1)
                    {
                        timer.oneSecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
                    }
                    if (PositionManager.placement == 2)
                    {
                        timer.twoSecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
                    }
                }

                if (LapTimeManager.MinuteCount <= 9)
                {
                    MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
                    if (PositionManager.placement == 1)
                    {
                        timer.oneMinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";

                    }
                    if (PositionManager.placement == 2&&!timer.playerwon)
                    {
                        timer.twoMinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
                    }
                }
                else
                {
                    MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
                    if (PositionManager.placement == 1)
                    {
                        MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";

                    }
                    if (PositionManager.placement == 2)
                    {
                        MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
                    }

                }

                MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
                if (PositionManager.placement == 1)
                {
                    timer.oneMilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;

                }
                if (PositionManager.placement == 2)
                {
                    timer.twoMilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
                }

                LapTimeManager.MinuteCount = 0;
                LapTimeManager.SecondCount = 0;
                LapTimeManager.MilliCount = 0;

            }
            if (lap.lapNumber>3)
            {
                lapNum.GetComponent<Text>().text = "Lap 3/3";//change 
                Debug.Log("WIN :D");
                over.SetActive(true);
            
                info.SetActive(false);
                Time.timeScale = 0f;
            }
        }
    }
    /// <summary>
    
    /// </summary>
 


}
