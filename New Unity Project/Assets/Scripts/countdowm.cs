using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class countdowm : MonoBehaviour
{
    public int countdownTime;
    public Text countdowndisplay;
    public AudioSource rf;
    public playerSkin player;
    public LapTimeManager lap;
    public GameObject[] pl;
    public PlayerBullet[] bull;
    public GameObject control;
    public GameObject SKIN;
    // Start is called before the first frame update
    void Start()
    {
        lap.gameObject.GetComponent<LapTimeManager>().enabled = false;
        rf.GetComponent<AudioSource>();
        pl[0].gameObject.GetComponent<PlayerMove>().enabled = false;
        bull[0].gameObject.GetComponent<PlayerBullet>().enabled = false;
        //pl[1].gameObject.GetComponent<PlayerMove>().enabled = false;
        //bull[1].gameObject.GetComponent<PlayerBullet>().enabled = false;
        //pl[2].gameObject.GetComponent<PlayerMove>().enabled = false;
        //bull[2].gameObject.GetComponent<PlayerBullet>().enabled = false;
        //pl[3].gameObject.GetComponent<PlayerMove>().enabled = false;
        //bull[3].gameObject.GetComponent<PlayerBullet>().enabled = false;
        //pl[4].gameObject.GetComponent<PlayerMove>().enabled = false;
        //bull[4].gameObject.GetComponent<PlayerBullet>().enabled = false;

        control.gameObject.SetActive(false);
        StartCoroutine(CountdowntoStart());
    }

    IEnumerator CountdowntoStart()
    {
     
            
        if (player.done==false)
         {
            
            
                 rf.Play();
            
            while (countdownTime > 0)
            {
               
                countdowndisplay.text = countdownTime.ToString();
                yield return new WaitForSeconds(1f);
                countdownTime--;
                lap.gameObject.GetComponent<LapTimeManager>().enabled = false;
                if (player.choose == 3)//yellow car :D 
                {
                    pl[2].gameObject.GetComponent<PlayerMove>().enabled = false;
                    bull[2].gameObject.GetComponent<PlayerBullet>().enabled = true;
                }

                

                control.gameObject.SetActive(false);
        }
            //rf.Play();
            countdowndisplay.text = "GO!";
            yield return new WaitForSeconds(1f);
            countdowndisplay.gameObject.SetActive(false);
            lap.gameObject.GetComponent<LapTimeManager>().enabled = true;
            if (player.choose == 3)//yellow car :D 
            {
                pl[2].gameObject.GetComponent<PlayerMove>().enabled = true;
                bull[2].gameObject.GetComponent<PlayerBullet>().enabled = true;
            }
            
            control.gameObject.SetActive(true);
        }

    }
  

}
