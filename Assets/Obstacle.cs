using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Obstacle Detected");
            //speed reduction
            other.GetComponentInChildren<InputManager>().SlowDown();
            //cause a loss of speed 
            //cause a loss of money
            //emotion?
        }
    }


}
