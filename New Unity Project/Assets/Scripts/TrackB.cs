using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("TrackB");
            SceneManager.LoadScene("TrackB");
        }
    }
}
