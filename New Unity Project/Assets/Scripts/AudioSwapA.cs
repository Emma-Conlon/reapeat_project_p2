using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwapA : MonoBehaviour
{
    public AudioClip newTrack;
    public GameObject audioB;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioB.SetActive(false);
            Debug.Log("ENTER");
            AudioManagerA.instance.swapTrack(newTrack);

        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            audioB.SetActive(false);
            Debug.Log("EXIT");
            AudioManagerA.instance.ReturnToDefault();
        }
    }
}
