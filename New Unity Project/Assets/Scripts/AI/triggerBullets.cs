using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerBullets : MonoBehaviour
{
    public bool triggerd;
    // Start is called before the first frame update
    void Start()
    {
        triggerd = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// if the player enters the range
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            triggerd = true;
            Debug.Log("PlayerInRange");
        }
    }

    /// <summary>
    /// if the player leaves the range
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            triggerd = false;
            Debug.Log("PlayerOutOfRange");
        }
    }
}
