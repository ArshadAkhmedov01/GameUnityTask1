using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(true);
        gameObject.tag = other.gameObject.tag;
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SetActive(true);
        gameObject.tag=collision.gameObject.tag;
    }

    void Start()
    {
        
    }

    
    
}
