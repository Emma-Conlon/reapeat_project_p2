using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CheckPointSingle : MonoBehaviour
{
    public int index;
  
    public LapTrigger lap;
   public AILapTrigger AIlap;
    public GameObject pl;
    void Start()
    {
        lap.GetComponent<LapTrigger>();
        AIlap.GetComponent<AILapTrigger>();
    }
    private  void OnTriggerEnter(Collider other)
    {
        other.tag = pl.tag;
        pl.tag = "Player";
        if (other.gameObject.CompareTag("Player"))
        {

            lap.CheckpointIndex = index;
            Debug.Log("PlayerWentThrough" + lap.CheckpointIndex);
        }

    }

    /// <summary>
    /// for the AI to regiter checkpoints
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider Col)
    {
       

        if (Col.gameObject.CompareTag("AI"))
        {

             AIlap.AICheckpointIndex = index;
             Debug.Log("Ai went through" + AIlap.AICheckpointIndex);
        }
    }
}
