using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTrigger : MonoBehaviour
{
    public float  lapNumber;
    public float CheckpointIndex;

    private void Start()
    {
        lapNumber = 1;
        CheckpointIndex = 0;
    }
}
