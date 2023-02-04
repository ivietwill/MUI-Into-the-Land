using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{

    [SerializeField] private float gravity = 20;
    private void Start()
    {
        //Rigidbody rb = GetComponent<Rigidbody>();
    }
    public void OnTriggerEnter(Collider other)
    {
          if(other.gameObject.name == "Player")
        {
            Debug.Log("Testing");
            transform.position += new Vector3(0, 1,0) * gravity * Time.deltaTime;
        }
        
    }
}
