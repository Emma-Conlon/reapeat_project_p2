using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIlapHandle : MonoBehaviour
{
  


    public float checkpointamt;
    public float index;
    public GameObject ai;
    public AILapTrigger aiLap;
 
    public GameObject over;
    public GameObject info;

    private void Start()
    {
        checkpointamt = 12;
        aiLap.GetComponent<AILapTrigger>();

    }

    private void OnTriggerEnter(Collider other)
    {
        ai.tag = "AI";
        other.tag = ai.tag;
        if (other.gameObject.CompareTag("AI"))
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
        }
    }
}
