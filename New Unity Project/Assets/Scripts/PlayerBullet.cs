using System;
using UnityEngine;
using UnityEngine.Audio;


public class PlayerBullet : MonoBehaviour
{
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private float launchForce = 700f;
    public AudioSource fire;
    private float velocity;
    private void Start()
    {
        velocity = 100;
        fire.GetComponent<AudioSource>();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            fire.Play();
            LaunchProjectile();
            Debug.Log("Launched");
        }
    }

    /// <summary>
    /// shoots bullet from players car 
    /// </summary>
    private void LaunchProjectile()
    {
      
            var projectileInstance = Instantiate(
                projectilePrefab,
                firePoint.position,
                firePoint.rotation);

            projectileInstance.AddForce(firePoint.forward * launchForce);
        velocity = firePoint.forward.x * launchForce;
        Debug.Log(velocity);
       
    }
}
