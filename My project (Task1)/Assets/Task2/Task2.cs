using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    private bool entered = false;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && !entered)
        {
            entered = true;
            Debug.Log("Toxundu");
            GetComponent<Task2>().enabled = false;
            
        }
    }
    

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
