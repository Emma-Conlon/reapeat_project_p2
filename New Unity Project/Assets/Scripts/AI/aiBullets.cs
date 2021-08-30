using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiBullets : MonoBehaviour
{
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private Rigidbody projectilePrefab;
    public triggerBullets box;
    private float boostingtimer;
    public GameObject bullet;
    [SerializeField]
    private float launchForce = 700f;
    public AudioSource fire;
    private float velocity;
    private Vector3 movement;
    private void Start()
    {


        fire.GetComponent<AudioSource>();
    }
    public void Update()
    {
        if (box.triggerd)//make it do so every few seconds
        {
            boostingtimer += Time.deltaTime;
            
            if (boostingtimer >= 2)
            {
                fire.Play();
                LaunchProjectile();
                Debug.Log("boostingtimer");
                boostingtimer = 0;
               
            }
        }

    }

    /// <summary>
    /// shoots bullet from AIS car 
    /// </summary>
    private void LaunchProjectile()
    {
        movement = new Vector3(0.0f, 0.0f, velocity);
        var projectileInstance = Instantiate(
                projectilePrefab,
                firePoint.position,
                firePoint.rotation);


        projectileInstance.AddForce(firePoint.forward * launchForce * PlayerMove.motorForce);

        Debug.Log("BulletSpeed" + projectileInstance.velocity);
    }
}
