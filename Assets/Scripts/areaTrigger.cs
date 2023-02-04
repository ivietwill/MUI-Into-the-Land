using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaTrigger : MonoBehaviour
{
    [SerializeField] public GameObject constraint;
    [SerializeField] public GameObject player;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            constraint.SetActive(true);
        }
    }
}
