using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOverTime : MonoBehaviour
{
    public float xSpeed = 10;
    public float ySpeed = 10;
    public float zSpeed = 10;

    void Update()
    {
        Debug.Log(Time.deltaTime);

        transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);
    }
}
