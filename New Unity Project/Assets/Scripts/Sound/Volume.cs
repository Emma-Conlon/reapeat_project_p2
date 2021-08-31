using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    public AudioSource AudioSource;
    public PlayerBullet[] gunfire;
    public aiBullets[] bullets;
    public playerSkin skin;
   
 
    public float musicVolume = 1f;
    public float gunVolume = 1f;
    public float carVolume = 1f;
    void Start()
    {

        AudioSource.Play();
        bullets[0].GetComponent<aiBullets>();
        bullets[1].GetComponent<aiBullets>();
        bullets[2].GetComponent<aiBullets>();
        //gunfire.Play();
        if (skin.choose == 0)
        {
            gunfire[0].GetComponent<PlayerBullet>();
        }
        if (skin.choose == 1)
        {
            gunfire[1].GetComponent<PlayerBullet>();
        }
        if (skin.choose == 2)
        {
            gunfire[2].GetComponent<PlayerBullet>();
        }
        if (skin.choose == 3)
        {
            gunfire[3].GetComponent<PlayerBullet>();
        }
        if (skin.choose == 4)
        {
            gunfire[4].GetComponent<PlayerBullet>();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        AudioSource.volume = musicVolume;
        bullets[0].fire.volume = gunVolume;
        bullets[1].fire.volume = gunVolume;
        bullets[2].fire.volume = gunVolume;
        if (skin.choose == 0)
        {
            gunfire[0].fire.volume = gunVolume;

        }
        if (skin.choose == 1)
        {
            gunfire[1].fire.volume = gunVolume;

        }
        if (skin.choose == 2)
        {
            gunfire[2].fire.volume = gunVolume;

        }
        if (skin.choose == 3)
        {
            gunfire[3].fire.volume = gunVolume;

        }
        if (skin.choose == 4)
        {
            gunfire[4].fire.volume = gunVolume;

        }
    }
    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }

    public void updategun(float volume)
    {
        gunVolume = volume;
    }

    public void updateacceration(float volume)
    {
        carVolume = volume;
    }
    
}

