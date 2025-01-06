using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Conveyor : MonoBehaviour
{
    public float speed;
    Rigidbody conv;
    void Start()
    {
        conv = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        Vector3 pos = conv.position;    // store the conv position
        conv.position = conv.position + Vector3.back * speed * Time.fixedDeltaTime;
        conv.MovePosition(pos);
    }

}
