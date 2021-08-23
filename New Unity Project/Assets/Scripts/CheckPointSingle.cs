using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CheckPointSingle : MonoBehaviour
{
    public int index;
    public int rindex;
    public LapTrigger[] lap;
   public AILapTrigger AIlap;
    public GameObject[] pl;
    public playerSkin skin;
    void Start()
    {
        if (skin.choose == 0)
        {
            lap[0].GetComponent<LapTrigger>();
        }
        if (skin.choose == 1)
        {
            lap[1].GetComponent<LapTrigger>();
        }
        if (skin.choose == 2)
        {
            lap[2].GetComponent<LapTrigger>();
        }
        if (skin.choose == 3)
        {
            lap[3].GetComponent<LapTrigger>();
        }
        if (skin.choose == 4)
        {
            lap[4].GetComponent<LapTrigger>();
        }
           
       
       
        AIlap.GetComponent<AILapTrigger>();
    }
    private  void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        { 
            if(skin.choose==0)
            {
                if (lap[0].CheckpointIndex==rindex+1 || lap[0].CheckpointIndex==rindex-1)
                {
                    lap[0].CheckpointIndex = rindex;
                    Debug.Log("RedPlayerWentThrough" + rindex);
                }
            

            }
            if (skin.choose == 1)
            {
                lap[1].CheckpointIndex = index;
                Debug.Log("BluePlayerWentThrough" + lap[1].CheckpointIndex);

            }
            if (skin.choose == 2)
            {
                lap[2].CheckpointIndex = index;
                Debug.Log("YellowPlayerWentThrough" + lap[2].CheckpointIndex);

            }
            if (skin.choose == 3)
            {
                lap[3].CheckpointIndex = index;
                Debug.Log("BlackPlayerWentThrough" + lap[3].CheckpointIndex);

            }
            if (skin.choose == 4)
            {
                lap[4].CheckpointIndex = index;

                Debug.Log("GreyPlayerWentThrough" + lap[4].CheckpointIndex);

            }
         
        }

    }

    /// <summary>
    /// for the AI to regiter checkpoints
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider Col)
    {
       

        if (Col.tag == "AI")
        {

             AIlap.AICheckpointIndex = index;
             Debug.Log("Ai went through" + AIlap.AICheckpointIndex);
        }
    }
}
