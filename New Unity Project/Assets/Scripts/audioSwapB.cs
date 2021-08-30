using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSwapB : MonoBehaviour
{
    public AudioClip newTrack;
    public GameObject swapA;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            swapA.SetActive(false);
            Debug.Log("ENTER");
            audioManagerB.instance.swapTrack(newTrack);
          
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            swapA.SetActive(true);
            Debug.Log("EXIT");
            audioManagerB.instance.ReturnToDefault();
        }
    }
}
