using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapHandle : MonoBehaviour
{
    public float checkpointamt;
    public float index;
    public playerSkin skin;
    public LapTrigger[] lap;
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
        if (skin.choose == 0)
        {
            lap[0].GetComponent<LapTrigger>();
            lapNum.GetComponent<Text>().text = "Lap 1/3";//change
        }
        if (skin.choose == 1)
        {
            lap[1].GetComponent<LapTrigger>();
            lapNum.GetComponent<Text>().text = "Lap 1/3";//change
        }
        if (skin.choose == 2)
        {
            lap[2].GetComponent<LapTrigger>();
            lapNum.GetComponent<Text>().text = "Lap 1/3";//change
        }
        if (skin.choose == 3)
        {
            lap[3].GetComponent<LapTrigger>();
            lapNum.GetComponent<Text>().text = "Lap 1/3";//change
        }
        if (skin.choose == 4)
        {
            lap[4].GetComponent<LapTrigger>();
            lapNum.GetComponent<Text>().text = "Lap 1/3";//change
        }
        aiLap.GetComponent<AILapTrigger>();
         

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            ///checks to see all checkpoints have been passed 
            if (skin.choose == 0)
            {
                if (lap[0].CheckpointIndex == checkpointamt && lap[0].lapNumber <= 3)
                {
                    lap[0].CheckpointIndex = 0;
                    lap[0].lapNumber++;
                    Debug.Log(lap[0].lapNumber);
                    lapNum.GetComponent<Text>().text = "Lap" + lap[0].lapNumber + "/3";//change 
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
                if (lap[0].lapNumber > 3)
                {
                    lapNum.GetComponent<Text>().text = "Lap 3/3";//change 
                    Debug.Log("WIN :D");
                    over.SetActive(true);

                    info.SetActive(false);
                    Time.timeScale = 0f;
                }
            }
            if (skin.choose == 1)
            {
                if (lap[1].CheckpointIndex == checkpointamt && lap[1].lapNumber <= 3)
                {
                    lap[1].CheckpointIndex = 0;
                    lap[1].lapNumber++;
                    Debug.Log(lap[1].lapNumber);
                    lapNum.GetComponent<Text>().text = "Lap" + lap[1].lapNumber + "/3";//change 
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
                if (lap[1].lapNumber > 3)
                {
                    lapNum.GetComponent<Text>().text = "Lap 3/3";//change 
                    Debug.Log("WIN :D");
                    over.SetActive(true);

                    info.SetActive(false);
                    Time.timeScale = 0f;
                }
            }
            if (skin.choose == 2)
            {
                if (lap[2].CheckpointIndex == checkpointamt && lap[2].lapNumber <= 3)
                {
                    lap[2].CheckpointIndex = 0;
                    lap[2].lapNumber++;
                    Debug.Log(lap[2].lapNumber);
                    lapNum.GetComponent<Text>().text = "Lap" + lap[2].lapNumber + "/3";//change 
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
                if (lap[2].lapNumber > 3)
                {
                    lapNum.GetComponent<Text>().text = "Lap 3/3";//change 
                    Debug.Log("WIN :D");
                    over.SetActive(true);

                    info.SetActive(false);
                    Time.timeScale = 0f;
                }
            }
            if (skin.choose == 3)
            {
                if (lap[3].CheckpointIndex == checkpointamt && lap[3].lapNumber <= 3)
                {
                    lap[3].CheckpointIndex = 0;
                    lap[3].lapNumber++;
                    Debug.Log(lap[3].lapNumber);
                    lapNum.GetComponent<Text>().text = "Lap" + lap[3].lapNumber + "/3";//change 
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
                if (lap[3].lapNumber > 3)
                {
                    lapNum.GetComponent<Text>().text = "Lap 3/3";//change 
                    Debug.Log("WIN :D");
                    over.SetActive(true);

                    info.SetActive(false);
                    Time.timeScale = 0f;
                }
            }
            if (skin.choose == 4)
            {
                if (lap[4].CheckpointIndex == checkpointamt && lap[4].lapNumber <= 3)
                {
                    lap[4].CheckpointIndex = 0;
                    lap[4].lapNumber++;
                    Debug.Log(lap[4].lapNumber);
                    lapNum.GetComponent<Text>().text = "Lap" + lap[4].lapNumber + "/3";//change 
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
                if (lap[4].lapNumber > 3)
                {
                    lapNum.GetComponent<Text>().text = "Lap 3/3";//change 
                    Debug.Log("WIN :D");
                    over.SetActive(true);

                    info.SetActive(false);
                    Time.timeScale = 0f;
                }
            }
            
        }
    }
    /// <summary>
    
    /// </summary>
 


}
