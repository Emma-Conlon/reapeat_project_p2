using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AIlapHandle : MonoBehaviour
{
  


    public float checkpointamt;
    public float index;
    public GameObject ai;
    public AILapTrigger aiLap;
    public GameObject MinuteDisplay;
    public results timer;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;
    public GameObject over;
    public GameObject info;

    private void Start()
    {
        checkpointamt = 12;
        aiLap.GetComponent<AILapTrigger>();

    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag=="AI")
        {

            if (aiLap.AICheckpointIndex == checkpointamt && aiLap.AIlapNumber <= 3)
            {
                aiLap.AICheckpointIndex = 0;
                aiLap.AIlapNumber++;
                Debug.Log(aiLap.AIlapNumber);
                // lapNum.GetComponent<Text>().text = "Lap" + aiLap.AIlapNumber + "/3";//change 
            }
            if (aiLap.AIlapNumber > 3)
            {
                // lapNum.GetComponent<Text>().text = "Lap 3/3";//change 
                Debug.Log(" AI WON D:");
                over.SetActive(true);
                info.SetActive(false);
                Time.timeScale = 0f;
            }
            if (LapTimeManager.SecondCount <= 9)
            {
                SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                if (PositionManager.placement == 1)
                {
                    timer.oneSecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";

                }
                if (PositionManager.placement == 2)
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
                if (PositionManager.placement == 2 && !timer.playerwon)
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
    }
    
}
