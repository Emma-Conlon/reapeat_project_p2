using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public int marktracker;
    public GameObject marker;
    public GameObject Mark1;
    public GameObject Mark2;
    public GameObject Mark3;
    public GameObject Mark4;
    public GameObject Mark5;
    public GameObject Mark6;
    public GameObject Mark7;
    public GameObject Mark8;
    public GameObject Mark9;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;
    public GameObject Mark18;
    public GameObject Mark19;
    public GameObject Mark20;
    public GameObject Mark21;
    public GameObject Mark22;
    public GameObject Mark23;
    public GameObject Mark24;
    public GameObject Mark25;
    public GameObject Mark26;
    public GameObject Mark27;
    public GameObject ai;
    // Start is called before the first frame update
    void Update()
    {
        if(marktracker==0)
        {
            marker.transform.position = Mark1.transform.position;
        }
        if (marktracker == 1)
        {
            marker.transform.position = Mark2.transform.position;
        }
        if (marktracker == 2)
        {
            marker.transform.position = Mark3.transform.position;
        }
        if (marktracker == 3)
        {
            marker.transform.position = Mark4.transform.position;
        }
        if (marktracker == 4)
        {
            marker.transform.position = Mark5.transform.position;
        }
        if (marktracker == 5)
        {
            marker.transform.position = Mark6.transform.position;
        }
         if (marktracker == 6)
        {
            marker.transform.position = Mark7.transform.position;
        }
        if (marktracker == 7)
        {
            marker.transform.position = Mark8.transform.position;
        }
        if (marktracker == 8)
        {
            marker.transform.position = Mark9.transform.position;
        }
        if (marktracker == 9)
        {
            marker.transform.position = Mark10.transform.position;
        }
        if (marktracker == 10)
        {
            marker.transform.position = Mark11.transform.position;
        }
        if (marktracker == 11)
        {
            marker.transform.position = Mark12.transform.position;
        }
        if (marktracker == 12)
        {
            marker.transform.position = Mark13.transform.position;
        }
        if (marktracker == 13)
        {
            marker.transform.position = Mark14.transform.position;
        }
        if (marktracker == 14)
        {
            marker.transform.position = Mark15.transform.position;
        }
        if (marktracker == 15)
        {
            marker.transform.position = Mark16.transform.position;
        }
        if (marktracker == 16)
        {
            marker.transform.position = Mark17.transform.position;
        }
        if (marktracker == 17)
        {
            marker.transform.position = Mark18.transform.position;
        }
        if (marktracker == 18)
        {
            marker.transform.position = Mark19.transform.position;
        }
        if (marktracker == 19)
        {
            marker.transform.position = Mark20.transform.position;
        }
        if (marktracker == 20)
        {
            marker.transform.position = Mark21.transform.position;
        }
        if (marktracker == 21)
        {
            marker.transform.position = Mark22.transform.position;
        }
        if (marktracker == 22)
        {
            marker.transform.position = Mark23.transform.position;
        }
        if (marktracker == 23)
        {
            marker.transform.position = Mark24.transform.position;
        }
        if (marktracker == 24)
        {
            marker.transform.position = Mark25.transform.position;
        }
        if (marktracker == 25)
        {
            marker.transform.position = Mark26.transform.position;
        }
        if (marktracker == 26)
        {
            marker.transform.position = Mark27.transform.position;
        }
    }

    // Update is called once per frame
    private IEnumerator OnTriggerEnter(Collider other)
    {
        //ai.tag = "AI";
        //other.tag = ai.tag;
       // if (other.gameObject.CompareTag("AI"))
            if (other.tag=="carPos")
            {
            Debug.Log("cube");
            this.GetComponent<BoxCollider>().enabled = false;
            marktracker += 1;
            if(marktracker==27)
            {
                marktracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
            }
    }
   
}
