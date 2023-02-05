using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPointScript3 : MonoBehaviour
{

    [SerializeField] Vector3 vectorPoint;
    [SerializeField] Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
      
        if (other.gameObject.tag == "CheckPoints3")
        {
            vectorPoint = other.transform.position;
            other.gameObject.SetActive(false);
        }


        if (other.gameObject.tag == "FallPoints")
        {
            rb.isKinematic = false;
            transform.position = vectorPoint;

        }


    }
}
