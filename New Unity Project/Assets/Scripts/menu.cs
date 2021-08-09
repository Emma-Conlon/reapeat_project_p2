using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
 
    public void Level1()
    {
        SceneManager.LoadScene("TrackA");
    }
    public void Level2()
    {
        SceneManager.LoadScene("TrackB");
    }
}