using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Translate : MonoBehaviour
{
    public float speed = 5.0f;
    public bool reverse = false;
    void Start()
    {

    }

    void Update()
    {
        float translation = speed * Time.deltaTime;
        if (reverse)
        {
            transform.Translate(Vector3.up * translation * -1);
        }
        else
        {
            transform.Translate(Vector3.up * translation );
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sensor"))
        {
            reverse = true;
            Debug.Log("Touch!");
        }    
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sensor"))
        {
            Debug.Log("No Touch!");
        }    
        
    }
}
