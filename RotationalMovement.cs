using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Start is called before the first frame update
public class RotationalMovement : MonoBehaviour
{
    public float RPS = 60f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        float rotationAmount = RPS * Time.fixedDeltaTime;
        Quaternion deltaRotation = Quaternion.Euler(0f, rotationAmount, 0f);
        rb.MoveRotation(rb.rotation *  deltaRotation);
    }

}

