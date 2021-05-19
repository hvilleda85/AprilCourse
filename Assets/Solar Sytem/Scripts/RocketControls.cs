using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControls : MonoBehaviour
{
    private Rigidbody rigidbody;
    public Light engineLight;
    public float turningForce;
    public float engineForce;
    public float dragNumber;
    public Rigidbody laserBoltPrefab;
    public Transform barrel;
    public float laserImpulse;
    public AudioClip pewSound;

    // Start is called before the first frame update
    void Start()
    {
        // Store the rigibdbody from this object
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleRotation();

        HandleRocketImpulse();

        // Take off acc or dec button rocket ship slows down and stops eventually
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            DecelerateRocket(dragNumber);
        }

        // If the left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            //Create a new laser bolt
            Rigidbody laserBolt = Instantiate(laserBoltPrefab, barrel.position, Quaternion.identity);
            laserBolt.transform.up = transform.forward;

            //Match the laser bolt's velocity with the rocket's velocity
            laserBolt.velocity = rigidbody.velocity;

            //Apply an impulse to laser bolt
            laserBolt.AddForce(laserBolt.transform.up * laserImpulse);

            //Play a pew pew sound
            GetComponent<AudioSource>().PlayOneShot(pewSound);
        }
    }

    private void HandleRocketImpulse()
    {

        // Keep track of the engine
        bool engineOn = false;

        // If the W key is being held down
        if (Input.GetKey(KeyCode.W))
        {
            // Apply a forward force to the rocket
            rigidbody.AddForce(transform.forward * engineForce * Time.deltaTime);
            DecelerateRocket(0);

            // The engine is on
            engineOn = true;
        }

        // If the S key is being held down
        if (Input.GetKey(KeyCode.S))
        {
            // Apply a forward force to the rocket
            rigidbody.AddForce(transform.forward * -engineForce * Time.deltaTime);
            DecelerateRocket(0);

            // The engine is on
            engineOn = true;
        }

        // Turn on the engine light only when the engine is on
        engineLight.enabled = engineOn;
    }

    private void HandleRotation()
    {
        // Only rotate when the right mouse button is held down
        if (Input.GetMouseButton(1) || Input.GetKey(KeyCode.Space))
        {
            // Get the mouse inputs
            //float yaw = Input.GetAxis("Mouse X");
            float pitch = Input.GetAxis("Mouse Y");

            // Turn rocket ship left or right using  A, D, < or > keys
            float horizontalMovement = Input.GetAxis("Horizontal");

            // Apply some rotation to the rocket based on the mouse inputs
            rigidbody.AddRelativeTorque(
                pitch * turningForce * Time.deltaTime,                  // Pitch (X-Axis)
                horizontalMovement * turningForce * Time.deltaTime,    // Yaw (Y-Axis)
                0);                                                   // Roll (Z-Axis, not used here)
        }
    }

    void DecelerateRocket(float dragAmount)
    {
        rigidbody.drag = dragAmount;
    }
}
