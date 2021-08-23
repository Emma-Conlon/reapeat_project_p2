using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TrackCheckpoints : MonoBehaviour
{
    public int checkpointamt;
    public LapTrigger[] lap;
    public AILapTrigger aiLap;
    public playerSkin skin;
    void Start()
    {
        lap[0].GetComponent<LapTrigger>();
        lap[1].GetComponent<LapTrigger>();
        lap[2].GetComponent<LapTrigger>();
        lap[3].GetComponent<LapTrigger>();
        lap[4].GetComponent<LapTrigger>();
    }

    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            if (skin.choose == 0)
            {


                if (lap[0].CheckpointIndex == checkpointamt)
                {
                    lap[0].CheckpointIndex = 0;
                    lap[0].lapNumber++;
                }

            }
            if (skin.choose == 1)
            {


                if (lap[1].CheckpointIndex == checkpointamt)
                {
                    lap[1].CheckpointIndex = 0;
                    lap[1].lapNumber++;
                }

            }
            if (skin.choose == 2)
            {

                if (lap[2].CheckpointIndex == checkpointamt)
                {
                    lap[2].CheckpointIndex = 0;
                    lap[2].lapNumber++;
                }

            }
            if (skin.choose == 3)
            {


                if (lap[3].CheckpointIndex == checkpointamt)
                {
                    lap[3].CheckpointIndex = 0;
                    lap[3].lapNumber++;
                }

            }
            if (skin.choose == 4)
            {


                if (lap[4].CheckpointIndex == checkpointamt)
                {
                    lap[4].CheckpointIndex = 0;
                    lap[4].lapNumber++;
                }

            }

        }
    }
    /// <summary>
    /// CHECKS AI'S LAP NUM
    /// </summary>
    /// <param name="Col"></param>
    private void OnTriggerEnter(Collider Col)
    {

        if (Col.tag == "AI")
        {
            if (aiLap.AICheckpointIndex == checkpointamt)
            {
                aiLap.AICheckpointIndex = 0;
                aiLap.AIlapNumber++;
            }
        }
    }



}
