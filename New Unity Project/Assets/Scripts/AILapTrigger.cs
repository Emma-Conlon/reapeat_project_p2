using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AILapTrigger : MonoBehaviour
{
    public float AIlapNumber;
    public float AICheckpointIndex;

    private void Start()
    {
        AIlapNumber = 1;
        AICheckpointIndex = 0;
    }
}
