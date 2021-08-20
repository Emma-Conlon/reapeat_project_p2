using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownPos : MonoBehaviour
{
    public GameObject PosirionDisplay;
 
    public AILapTrigger ailap;
    public LapTrigger playerlap;
    
    private void Start()
    {

        playerlap.GetComponent<LapTrigger>();
        ailap.GetComponent<AILapTrigger>();
      


    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //if the players laps are lower or equal to oppoments they will go first 
             if (playerlap.lapNumber <= ailap.AIlapNumber)
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
                    UpPOS.Place=2;                                                               //text.color = Color.cyan;
                }
                // text.color = Color.yellow;
            }

        }
    }
}
