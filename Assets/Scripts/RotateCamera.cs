using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizantalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * horizantalInput * Time.deltaTime * rotationSpeed);
    }
}
