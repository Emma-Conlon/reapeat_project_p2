using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSkin : MonoBehaviour
{
    public  int choose;
    public  bool done;
    public PlayerMove[] play;
    public GameObject red;
    public GameObject blue;
    public GameObject yellow;
    public GameObject black;
    public GameObject Ai;
    public GameObject grey;
     
    // Start is called before the first frame update
    private void Start()
    {
        play[0].GetComponent<PlayerMove>();
        play[1].GetComponent<PlayerMove>();
        play[2].GetComponent<PlayerMove>();
        play[3].GetComponent<PlayerMove>();
        play[4].GetComponent<PlayerMove>();
        done = false;
        choose = -1;
        Time.timeScale = 0f;
        Ai.SetActive(false);

    }
    public void chooseRed()
    {
        done = true;
        choose = 0;
        play[0].choose = choose;
        Debug.Log("Red car choosen "+play[0].choose);
        Time.timeScale = 1f;
        red.SetActive(true);
        Ai.SetActive(true);

    }

    public void chooseBlue()
    {
        done = true;
        choose = 1;
        play[1].choose = choose;
        Debug.Log("blue car choosen " + play[1].choose);
        Time.timeScale = 1f;
      
        blue.SetActive(true);
    }
    public void chooseYellow()
    {
        choose = 2;
        play[2].choose = choose;
        Debug.Log("yellow car choosen " + play[2].choose);
        done = true;
        Time.timeScale = 1f;
       
        yellow.SetActive(true);
    }
    public void chooseBlack()
    {
        done = true;
        choose = 3;
        Time.timeScale = 1f;
        play[3].choose = choose;
        Debug.Log("black car choosen " + play[3].choose);
        black.SetActive(true);
    }
    public void chooseGrey()
    {
        done = true;
        choose = 4;
        Time.timeScale = 1f;
        play[4].choose = choose;
        Debug.Log("grey car choosen " + play[4].choose);
        grey.SetActive(true);
    }

}
