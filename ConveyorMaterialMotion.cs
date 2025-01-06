using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ConveyorMaterialMotion : MonoBehaviour 
{
    public float speed = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        float Transition = Time.time * speed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, Transition);
    }

}
