using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class results : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public GameObject score;
    public playerSkin skin;
    public GameObject playersMinuteDisplay;
    public GameObject playersSecondDisplay;
    public GameObject playersMilliDisplay;
    public GameObject oneMinuteDisplay;
    public GameObject oneSecondDisplay;
    public GameObject oneMilliDisplay;
    public GameObject twoMinuteDisplay;
    public GameObject twoSecondDisplay;
    public AIHealth car;
    public MoveBullet[] play;
    public bool playerdead;
    public GameObject twoMilliDisplay;
    public bool playerwon;
    //public GameObject aiMinuteDisplay;
    //public GameObject aiSecondDisplay;
    //public GameObject aiMilliDisplay;
    private void Start()
    {
        car.GetComponent<AIHealth>();
        //PositionManager.placement = 2;
        first.GetComponent<Text>().text = "1stPlace";//change 
        second.GetComponent<Text>().text = "2ndPlace";//change 
        score.GetComponent<Text>().text = "Score:";//change 
        playerwon = false;
        //playerdead = true;
        resultsGrid();
        if (skin.choose == 0)
        {
            score.GetComponent<Text>().text = "Score:" + play[0].scored.ToString();//change 
        }
        if (skin.choose == 1)
        {
            score.GetComponent<Text>().text = "Score:" + play[1].scored.ToString();//change 
        }
        if (skin.choose == 2)
        {
            score.GetComponent<Text>().text = "Score:" + play[2].scored.ToString();//change 
        }
        if (skin.choose == 3)
        {
            score.GetComponent<Text>().text = "Score:" + play[3].scored.ToString();//change 
        }
        if (skin.choose == 4)
        {
            score.GetComponent<Text>().text = "Score:" + play[4].scored.ToString();//change         }
        }

        // Start is called before the first frame update
        void resultsGrid()
        {
            Debug.Log("ResultsSec" + UpPOS.Place);
            if(car.currentHealth<=0)
            {
                
                playerwon = true;
                first.GetComponent<Text>().text = "Player";//change 
                if (skin.choose == 0)
                {
                    score.GetComponent<Text>().text = "Score:" + play[0].scored.ToString();//change 
                }
                if (skin.choose == 1)
                {
                    score.GetComponent<Text>().text = "Score:" + play[1].scored.ToString();//change 
                }
                if (skin.choose == 2)
                {
                    score.GetComponent<Text>().text = "Score:" + play[2].scored.ToString();//change 
                }
                if (skin.choose == 3)
                {
                    score.GetComponent<Text>().text = "Score:" + play[3].scored.ToString();//change 
                }
                if (skin.choose == 4)
                {
                    score.GetComponent<Text>().text = "Score:" + play[4].scored.ToString();//change         
                }

                second.GetComponent<Text>().text = "AI";//change 
            }
            if (playerdead)
            {

                playerwon = true;
                first.GetComponent<Text>().text = "AI";//change 
                if (skin.choose == 0)
                {
                    score.GetComponent<Text>().text = "Score:" + play[0].scored.ToString();//change 
                }
                if (skin.choose == 1)
                {
                    score.GetComponent<Text>().text = "Score:" + play[1].scored.ToString();//change 
                }
                if (skin.choose == 2)
                {
                    score.GetComponent<Text>().text = "Score:" + play[2].scored.ToString();//change 
                }
                if (skin.choose == 3)
                {
                    score.GetComponent<Text>().text = "Score:" + play[3].scored.ToString();//change 
                }
                if (skin.choose == 4)
                {
                    score.GetComponent<Text>().text = "Score:" + play[4].scored.ToString();//change         
                }

                second.GetComponent<Text>().text = "Player";//change 
            }
            if (PositionManager.placement == 1 || UpPOS.Place == 1||!playerdead)
            {
                playerwon = true;
                first.GetComponent<Text>().text = "Player";//change 
                if (skin.choose == 0)
                {
                    score.GetComponent<Text>().text = "Score:" + play[0].scored.ToString();//change 
                }
                if (skin.choose == 1)
                {
                    score.GetComponent<Text>().text = "Score:" + play[1].scored.ToString();//change 
                }
                if (skin.choose == 2)
                {
                    score.GetComponent<Text>().text = "Score:" + play[2].scored.ToString();//change 
                }
                if (skin.choose == 3)
                {
                    score.GetComponent<Text>().text = "Score:" + play[3].scored.ToString();//change 
                }
                if (skin.choose == 4)
                {
                    score.GetComponent<Text>().text = "Score:" + play[4].scored.ToString();//change         }
                }

                second.GetComponent<Text>().text = "AI";//change 
            }

            if (PositionManager.placement == 2 || UpPOS.Place == 2||playerdead)
            {
                playerwon = false;
                first.GetComponent<Text>().text = "AI";//change 

                second.GetComponent<Text>().text = "Player";//change 
                if (skin.choose == 0)
                {
                    score.GetComponent<Text>().text = "Score:" + play[0].scored.ToString();//change 
                }
                if (skin.choose == 1)
                {
                    score.GetComponent<Text>().text = "Score:" + play[1].scored.ToString();//change 
                }
                if (skin.choose == 2)
                {
                    score.GetComponent<Text>().text = "Score:" + play[2].scored.ToString();//change 
                }
                if (skin.choose == 3)
                {
                    score.GetComponent<Text>().text = "Score:" + play[3].scored.ToString();//change 
                }
                if (skin.choose == 4)
                {
                    score.GetComponent<Text>().text = "Score:" + play[4].scored.ToString();//change         }
                }
            }
            // text.color = Color.yellow;
            // }


        }
    }
}
