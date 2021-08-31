using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RaceOver : MonoBehaviour
{
    public UpPOS up;
    public GameObject Placement;
    private bool won;
    private bool lost;
    public void FixedUpdate()
    {
        if(UpPOS.Place==1)
        {
            Placement.GetComponent<Text>().text ="YOU WON\nPosition:"+ UpPOS.Place+"st";//change 
        }
        if(UpPOS.Place==2)
        {
            Placement.GetComponent<Text>().text = "YOU Lost\nPosition:" + UpPOS.Place + "nd";//change 
        }
       // Placement.GetComponent<Text>().text = up.Place;//change 
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void Replay()
    {
        SceneManager.LoadScene("TrackA");
      
        Time.timeScale = 1f;
        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
    }

    public void ReplayB()
    {
        SceneManager.LoadScene("TrackB");

        Time.timeScale = 1f;
        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
    }
    public void Resume()
    {
        

        Time.timeScale = 1f;

    }

    public void newGame()
    {

        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
