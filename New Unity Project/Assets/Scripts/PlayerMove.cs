using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMove : MonoBehaviour
{
    public float playerDistance;
    public int scorer;
    public int maxHealth = 100;
    public int currentHealth;
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    public GameObject text;
    public ParticleSystem particle;
    public int choose;
    public GameObject over;
    public GameObject pause;
    public MeshRenderer wheels1;
    public MeshRenderer wheels2;
    public MeshRenderer wheels3;
    public MeshRenderer wheels4;
    public GameObject body;
    [SerializeField] public static float horizontalInput;
    [SerializeField] public static float verticalInput;
    private float currentbreakforce;
    private float steeringAngle;
    private bool isBreaking;
    public bool sheild;
    public bool pauseScreen;

    [SerializeField] public static float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteeringAngle;
    [SerializeField] private WheelCollider frontleftWheelCollider;
    [SerializeField] private WheelCollider frontrightWheelCollider;
    [SerializeField] private WheelCollider backleftWheelCollider;
    [SerializeField] private WheelCollider backrightWheelCollider;

    [SerializeField] private Transform frontleftWheelTransform;
    [SerializeField] private Transform frontrightWheelTransform;
    [SerializeField] private Transform backleftWheelTransform;
    [SerializeField] private Transform backrightWheelTransform;
    private float boostingtimer;
    public PlayerHealth health;

    private void Start()
    {
        scorer = 0;
        motorForce = 10000;
        currentHealth = maxHealth;
        health.SetMaxHealth(maxHealth);
        sheild = false;
        boostingtimer = 0;
    }
    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if(!sheild)
            {
                TakeDamage(20);
               
            }
            else
            {
                TakeDamage(0);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
          
            pause.SetActive(true);//shows end page
            Time.timeScale = 0f;
        }
       
        if (currentHealth <= 0)
        {
            over.SetActive(true);//shows end page
            boostingtimer = +Time.deltaTime;

            particle.enableEmission = true;
            particle.Play();
            //wheels.SetActive(false);//shows end page
            body.SetActive(false);//shows particle
            wheels1.enabled = false;
            wheels2.enabled = false;
            wheels3.enabled = false;
            wheels4.enabled = false;
            if (boostingtimer >= 0)
            {
                Time.timeScale = 0f;
                boostingtimer = 0;
            }

        }
        text.GetComponent<Text>().text = frontleftWheelCollider.motorTorque.ToString();
    }
    private void GetInput()
    {
        verticalInput = Input.GetAxis(VERTICAL);
        horizontalInput = Input.GetAxis(HORIZONTAL);
        isBreaking = Input.GetKey(KeyCode.Space);
    }
    private void HandleMotor()
    {
        frontleftWheelCollider.motorTorque = verticalInput * motorForce;
     
        frontrightWheelCollider.motorTorque = verticalInput * motorForce;
        currentbreakforce = isBreaking ? breakForce : 0f;
        if(isBreaking)
        {
            ApplyBreaks();
        }
        if(!isBreaking)
        {

            frontleftWheelCollider.brakeTorque = 0;
            frontrightWheelCollider.brakeTorque = 0;
            backleftWheelCollider.brakeTorque = 0;
            backrightWheelCollider.brakeTorque = 0;
        }
         
    }

    private void ApplyBreaks()
    {
        frontleftWheelCollider.brakeTorque = currentbreakforce;
        frontrightWheelCollider.brakeTorque = currentbreakforce;
        backleftWheelCollider.brakeTorque = currentbreakforce;
        backrightWheelCollider.brakeTorque = currentbreakforce;
        if(Input.GetKey(KeyCode.W))
        {
            isBreaking = false;
            HandleMotor();
        }
    }

   

    private void HandleSteering()
    {
        steeringAngle = maxSteeringAngle * horizontalInput;
        frontleftWheelCollider.steerAngle=steeringAngle;
        frontrightWheelCollider.steerAngle = steeringAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontleftWheelCollider, frontleftWheelTransform);
        UpdateSingleWheel(frontrightWheelCollider, frontrightWheelTransform);
        UpdateSingleWheel(backleftWheelCollider, backleftWheelTransform);
        UpdateSingleWheel(backrightWheelCollider, backrightWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pose;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pose, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pose;
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        health.SetHealth(currentHealth);
    }
}
