using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{

    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

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


    private void Start()
    {
        motorForce = 1000;

        boostingtimer = 0;
    }
    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
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
        if (isBreaking)
        {
            ApplyBreaks();
        }
        if (!isBreaking)
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
        if (Input.GetKey(KeyCode.W))
        {
            isBreaking = false;
            HandleMotor();
        }
    }



    private void HandleSteering()
    {
        steeringAngle = maxSteeringAngle * horizontalInput;
        frontleftWheelCollider.steerAngle = steeringAngle;
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

}
