using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Transition : MonoBehaviour
{
    public float speed = 5.0f;
     void Start()
    {
        
    }

     void Update()
    {
        float translation = speed * Time.deltaTime;
        transform.Translate(Vector3.right * translation);
    }
}
