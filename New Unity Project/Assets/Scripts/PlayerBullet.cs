using System;
using UnityEngine;
using UnityEngine.Audio;


public class PlayerBullet : MonoBehaviour
{
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private Rigidbody projectilePrefab;
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
        if (Input.GetKeyDown(KeyCode.LeftControl))
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
        movement = new Vector3(0.0f, 0.0f, velocity);
        var projectileInstance = Instantiate(
                projectilePrefab,
                firePoint.position,
                firePoint.rotation);


        projectileInstance.AddForce(firePoint.forward * launchForce * PlayerMove.motorForce);

        Debug.Log("BulletSpeed" + projectileInstance.velocity);

    }


    /// <summary>
    /// should destroy bullet if hit :) 
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {

        Destroy(bullet);
        if (collision.gameObject.name == "PlayerBullet")
        {

            Destroy(bullet);
            Debug.Log("BulletGone");
        }

    }
}
    
