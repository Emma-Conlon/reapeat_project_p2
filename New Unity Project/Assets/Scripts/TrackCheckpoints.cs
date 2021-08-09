using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TrackCheckpoints : MonoBehaviour
{
    public int checkpointamt;
    public LapTrigger lap;
    void Start()
    {
        lap.GetComponent<LapTrigger>();
    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
         
            Debug.Log(lap.CheckpointIndex);
            //if(lap.CheckpointIndex==checkpointamt)
            //{
            //    lap.CheckpointIndex = 0;
            //    lap.lapNumber++;
            //}
        }
    }


}
