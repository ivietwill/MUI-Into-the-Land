using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
 
    //[SerializeField] private float gravity = 20;
    private void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
          if(other.gameObject.tag == "Player")
        {
            Debug.Log("Testing");

            Rigidbody rb = GetComponent<Rigidbody>();
            rb.isKinematic = false;

        }
        
    }
}
