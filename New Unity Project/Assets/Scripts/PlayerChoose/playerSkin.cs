using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSkin : MonoBehaviour
{
    public  int choose;
    public  bool done;
    public GameObject red;
    public GameObject blue;
    public GameObject yellow;
    public GameObject black;
    public GameObject Ai;
    public GameObject grey;
     
    // Start is called before the first frame update
    private void Start()
    {
        done = false;
        choose = 0;
        Time.timeScale = 0f;
        Ai.SetActive(false);

    }
    public void chooseRed()
    {
        done = true;
        choose = 1;
        Time.timeScale = 1f;
        red.SetActive(true);
      
    }

    public void chooseBlue()
    {
        done = true;
        choose = 2;
        Time.timeScale = 1f;
      
        blue.SetActive(true);
    }
    public void chooseYellow()
    {
        choose = 3;
        done = true;
        Time.timeScale = 1f;
       
        yellow.SetActive(true);
    }
    public void chooseBlack()
    {
        done = true;
        choose = 4;
        Time.timeScale = 1f;
       
        black.SetActive(true);
    }
    public void chooseGrey()
    {
        done = true;
        choose = 5;
        Time.timeScale = 1f;
        
        grey.SetActive(true);
    }

}
